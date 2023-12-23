using INNO.Domain.Entities.Organizations;
using INNO.Service.DTOs.Organizations;
using System.Linq.Expressions;

namespace INNO.Service.Interfaces
{
    public interface IOrganisationService
    {
        public Task<OrganizationForViewDTO> CreateAsync(OrganizationForCreationDTO startap);
        public Task<OrganizationForViewDTO> UpdateAsync(OrganizationForUpdateDTO startup);
        public Task<bool> DeleteAsync(long id);
        public Task<OrganizationForViewDTO> GetByIdAsync(Expression<Func<Organization, bool>> expression);
        public Task<ICollection<OrganizationForViewDTO>> GetAsync(Expression<Func<Organization, bool>> expression);
    }
}
