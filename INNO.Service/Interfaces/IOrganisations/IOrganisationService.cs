using INNO.Domain.Configuration;
using INNO.Domain.Entities.Organizations;
using INNO.Service.DTOs.Organizations;
using System.Linq.Expressions;

namespace INNO.Service.Interfaces.IOrganisations
{
    public interface IOrganisationService
    {
        public Task<OrganizationForViewDTO> CreateAsync(OrganizationForCreationDTO org);
        public Task<OrganizationForViewDTO> UpdateAsync(OrganizationForUpdateDTO org);
        public Task<bool> DeleteAsync(Expression<Func<Organization, bool>> expression);
        public Task<OrganizationForViewDTO> GetByIdAsync(Expression<Func<Organization, bool>> expression);
        public Task<ICollection<OrganizationForViewDTO>> GetAsync(PaginationParams @params, Expression<Func<Organization, bool>> expression = null );
    }
}
