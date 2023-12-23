﻿using AutoMapper;
using INNO.Data.IRepositories;
using INNO.Domain.Configuration;
using INNO.Domain.Entities.Organizations;
using INNO.Domain.Entities.Users;
using INNO.Service.DTOs.Startups;
using INNO.Service.DTOs.Users;
using INNO.Service.Exceptions;
using INNO.Service.Extantions;
using INNO.Service.Helpers;
using INNO.Service.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace INNO.Service.Services;

public class StartupService : IStartupService
{
    private readonly IGenericRepository<OwnerStartup> _repository;
    private readonly IMapper _mapper;
    public StartupService(IGenericRepository<OwnerStartup> repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<StartupForViewDTO> CreateAsync(StartupForCreationDTO startap)
    {
        var value = await  _repository.GetAsync(s => s.Title == startap.Title);
        if (value is not null)
        {
            throw new CustomException(400, "User already exsist");
        }
        var map = _mapper.Map<OwnerStartup>(startap);
        await _repository.CreateAsync(map);
        await _repository.SaveChangesAsync();

        return _mapper.Map<StartupForViewDTO>(startap);
    }

    public async Task<bool> DeleteAsync(Expression<Func<OwnerStartup, bool>> expression)
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

    public async Task<ICollection<StartupForViewDTO>> GetAsync(PaginationParams @params, Expression<Func<OwnerStartup, bool>> expression)
    {
        var values =  _repository.GetAllAsync(expression: expression, isTracking: false);
        return _mapper.Map<ICollection<StartupForViewDTO>>(await values.ToPagedList(@params).ToListAsync());
    }

    public async Task<StartupForViewDTO> GetByIdAsync(Expression<Func<OwnerStartup, bool>> expression)
    {
        var user = await _repository.GetAsync(expression);

        if (user is null)
            throw new CustomException(404, "User not found");

        return _mapper.Map<StartupForViewDTO>(user);
    }

    public async Task<StartupForViewDTO> UpdateAsync(long id, StartupForUpdateDTO startup)
    {
        var existUser = await _repository.GetAsync(
             u => u.Id == id);

        if (existUser == null)
            throw new CustomException(404, "User not found");

        existUser.UpdateAt = DateTime.UtcNow;
        existUser = await _repository.UpdateAsync(_mapper.Map(startup, existUser));
        await _repository.SaveChangesAsync();

        return _mapper.Map<StartupForViewDTO>(startup);
    }
}