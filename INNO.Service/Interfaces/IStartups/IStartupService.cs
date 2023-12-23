using INNO.Domain.Configuration;
using INNO.Domain.Entities.Organizations;
using INNO.Domain.Entities.Users;
using INNO.Service.DTOs.Startups;
using INNO.Service.DTOs.Users;
using System.Linq.Expressions;

namespace INNO.Service.Interfaces.IStartups
{
    public interface IStartupService
    {
        public Task<StartupForViewDTO> CreateAsync(StartupForCreationDTO startap);
        public Task<StartupForViewDTO> UpdateAsync(long id, StartupForUpdateDTO startup);
        public Task<bool> DeleteAsync(Expression<Func<OwnerStartup, bool>> expression);
        public Task<StartupForViewDTO> GetByIdAsync(Expression<Func<OwnerStartup, bool>> expression);
        public Task<ICollection<StartupForViewDTO>> GetAsync(PaginationParams @params, Expression<Func<OwnerStartup, bool>> expression);

    }
}
