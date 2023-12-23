using AutoMapper;
using INNO.Data.IRepositories;
using INNO.Domain.Configuration;
using INNO.Domain.Entities.Attachments;
using INNO.Domain.Entities.Organizations;
using INNO.Domain.Entities.Users;
using INNO.Service.DTOs.Organizations;
using INNO.Service.DTOs.PastExperiences;
using INNO.Service.Exceptions;
using INNO.Service.Extantions;
using INNO.Service.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace INNO.Service.Services;
public class PastExperienceService : IPastExperienceService
{
    private readonly IGenericRepository<PastExperience> _repository;
    private readonly IMapper _mapper;
    private readonly IFileService _fileService;

    public PastExperienceService(IGenericRepository<PastExperience> repository, IMapper mapper, IFileService fileService)
    {
        this._fileService = fileService;
        this._mapper = mapper;
        this._repository = repository;
    }

    public async Task<PastExperienceForViewDTO> CreateAsync(PastExperienceForCreationDTO Past)
    {
        Attachment file = default!;
        if (Past.File is not null)
            file = await _fileService.CreateAsync(Past.File);


        var value = await _repository.GetAsync(P => P.Title == Past.Title);
        if (value is not null)
        {
            throw new CustomException(400, "Experience  already exsist");
        }

        var map = _mapper.Map<PastExperience>(Past);

        await _repository.CreateAsync(map);
        await _repository.SaveChangesAsync();

        return _mapper.Map<PastExperienceForViewDTO>(Past);
    }

    public async Task<bool> DeleteAsync(Expression<Func<PastExperience, bool>> expression)
    {
        var value = await _repository.GetAsync(p => p.Title == p.Title);
        if (value is not null)
        {
            throw new CustomException(404, "Experience not found");
        }

        await _repository.DeleteAsync(p => p.Title == p.Title);
        await _repository.SaveChangesAsync();

        return true;
    }

    public async Task<ICollection<PastExperienceForViewDTO>> GetAsync(PaginationParams @params, Expression<Func<PastExperience, bool>> expression)
    {
        var values = _repository.GetAllAsync(expression: expression, isTracking: false);
        return _mapper.Map<ICollection<PastExperienceForViewDTO>>(await values.ToPagedList(@params).ToListAsync());

    }

    public async Task<PastExperienceForViewDTO> GetByIdAsync(Expression<Func<PastExperience, bool>> expression)
    {
        var past = await _repository.GetAsync(expression);

        if (past is null)
            throw new CustomException(404, "Experience not found");

        return _mapper.Map<PastExperienceForViewDTO>(past);
    }

    public async Task<PastExperienceForViewDTO> UpdateAsync(PastExperienceForUpdateDTO PastUpdate)
    {
        var existex = await _repository.GetAsync(
              p => p.Title == p.Title);

        if (existex == null)
            throw new CustomException(404, "Experience not found");


        existex.UpdateAt = DateTime.UtcNow;
        existex = await _repository.UpdateAsync(_mapper.Map(PastUpdate, existex));
        await _repository.SaveChangesAsync();

        return _mapper.Map<PastExperienceForViewDTO>(PastUpdate);
    }
}
