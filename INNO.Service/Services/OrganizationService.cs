using AutoMapper;
using INNO.Data.IRepositories;
using INNO.Domain.Configuration;
using INNO.Domain.Entities.Attachments;
using INNO.Domain.Entities.Organizations;
using INNO.Domain.Entities.Users;
using INNO.Service.DTOs.Organizations;
using INNO.Service.DTOs.Users;
using INNO.Service.Exceptions;
using INNO.Service.Extantions;
using INNO.Service.Helpers;
using INNO.Service.Interfaces.IExtantions;
using INNO.Service.Interfaces.IOrganisations;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace INNO.Service.Services;
public class OrganizationService : IOrganisationService
{
    private readonly IGenericRepository<Organization> _repository;
    private readonly IMapper _mapper;
    private readonly IFileService _fileService;
   
    public OrganizationService(IGenericRepository<Organization> repository, IMapper mapper, IFileService fileService)
    {
        this._repository = repository;
        this._mapper = mapper;
        this._fileService = fileService;
    }
    public async Task<OrganizationForViewDTO> CreateAsync(OrganizationForCreationDTO org)
    {
        Attachment file = default!;
        if (org.Image is not null)
            file = await _fileService.CreateAsync(org.Image);

        var value = await _repository.GetAsync(o => o.Title == org.Title);
        if (value is not null)
        {
            throw new CustomException(400, "Organization already exsist");
        }

        var map = _mapper.Map<Organization>(org);

        await _repository.CreateAsync(map);
        await _repository.SaveChangesAsync();

        return _mapper.Map<OrganizationForViewDTO>(org);
    }

    public async Task<bool> DeleteAsync(Expression<Func<Organization, bool >> expression)
    {
        var value = await _repository.GetAsync(o => o.Title == o.Title);
        if (value is not null)
        {
            throw new CustomException(404, "Organization not found");
        }

        await _repository.DeleteAsync(o => o.Title == o.Title);
        await _repository.SaveChangesAsync();

        return true;
    }

    public async Task<ICollection<OrganizationForViewDTO>> GetAsync(PaginationParams @params,
        Expression<Func<Organization, bool>> expression = null)
    {
        var values = _repository.GetAllAsync(expression: expression, isTracking: false);
        return _mapper.Map<ICollection<OrganizationForViewDTO>>(await values.ToPagedList(@params).ToListAsync());

    }

    public async Task<OrganizationForViewDTO> GetByIdAsync(Expression<Func<Organization, bool>> expression)
    {
        var organization = await _repository.GetAsync(expression);

        if (organization is null)
            throw new CustomException(404, "Organization not found");

        return _mapper.Map<OrganizationForViewDTO>(organization);
    }

    public async Task<OrganizationForViewDTO> UpdateAsync(OrganizationForUpdateDTO org)
    {
        var existOrg = await _repository.GetAsync(
              o => o.Title == o.Title);

        if (existOrg == null)
            throw new CustomException(404, "Organizations not found");


        existOrg.UpdateAt = DateTime.UtcNow;
        existOrg = await _repository.UpdateAsync(_mapper.Map(org, existOrg));
        await _repository.SaveChangesAsync();

        return _mapper.Map<OrganizationForViewDTO>(org);
    }
}
