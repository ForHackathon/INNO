
using INNO.Domain.Entities.Organizations;
using INNO.Service.DTOs.Startups;
using INNO.Service.DTOs.Users;
using System.Linq.Expressions;

namespace INNO.Service.Interfaces
{
    public interface IStartupService
    {
        public Task<StartupForViewDTO> CreateAsync(StartupForCreationDTO startap);
        public Task<StartupForViewDTO> UpdateAsync(StartupForUpdateDTO startup);
        public Task<bool> DeleteAsync(long id);
        public Task<StartupForViewDTO> GetByIdAsync(Expression<Func<OwnerStartup, bool>> expression);
        public Task<ICollection<StartupForViewDTO>> GetAsync(Expression<Func<OwnerStartup, bool>> expression);
    }
}
