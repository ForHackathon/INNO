﻿using AutoMapper;
using INNO.Data.IRepositories;
using INNO.Domain.Configuration;
using INNO.Domain.Entities.Users;
using INNO.Service.DTOs.Users;
using INNO.Service.Exceptions;
using INNO.Service.Extantions;
using INNO.Service.Helpers;
using INNO.Service.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace INNO.Service.Services;

public class UserService : IUserService
{
    private readonly IGenericRepository<User> _repository;
    private readonly IMapper _mapper;
    public UserService(IGenericRepository<User> repository, IMapper mapper)
    {
        this._repository = repository;
        this._mapper = mapper;
    }
    public async Task<UserForViewDTO> CreateAsync(UserForCreationDTO user)
    {
        var value = await _repository.GetAsync(u => u.Email == user.Email);
        if (value is not null)
        {
            throw new CustomException(400, "User already exsist");
        }

        user.Password = user.Password.Encrypt();
        var map = _mapper.Map<User>(user);

        await _repository.CreateAsync(map);
        await _repository.SaveChangesAsync();

        return _mapper.Map<UserForViewDTO>(user);

    }

    public async Task<bool> DeleteAsync(Expression<Func<User, bool>> expression)
    {
        var value = await _repository.GetAsync(expression);
        if (value is not null)
        {
            throw new CustomException(404, "User not found");
        }

        await _repository.DeleteAsync(expression);
        await _repository.SaveChangesAsync();

        return true;
    }

    public async Task<ICollection<UserForViewDTO>> GetAsync(PaginationParams @params, Expression<Func<User, bool>> expression)
    {
        var values = _repository.GetAllAsync(expression: expression, isTracking: false);
        return _mapper.Map<ICollection<UserForViewDTO>>(await values.ToPagedList(@params).ToListAsync());

    }

    public async Task<UserForViewDTO> GetByIdAsync(Expression<Func<User, bool>> expression)
    {
        var user = await _repository.GetAsync(expression);

        if (user is null)
            throw new CustomException(404, "User not found");

        return _mapper.Map<UserForViewDTO>(user);
    }

    public async Task<UserForViewDTO> UpdateAsync(long id, UserForUpdateDTO user)
    {
        var existUser = await _repository.GetAsync(
              u => u.Id == id);

        if (existUser == null)
            throw new CustomException(404, "User not found");

        var alreadyExistUser = await _repository.GetAsync(
            u => u.FirstName == user.FirstName && u.Id != HttpContextHelper.UserId);

        if (alreadyExistUser != null)
            throw new CustomException(400, "User with such username already exists");


        existUser.UpdateAt = DateTime.UtcNow;
        existUser = await _repository.UpdateAsync(_mapper.Map(user, existUser));
        await _repository.SaveChangesAsync();

        return _mapper.Map<UserForViewDTO>(user);
    }
}