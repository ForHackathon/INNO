using INNO.Data.IRepositories;
using INNO.Domain.Configuration;
using INNO.Domain.Entities.Application;
using INNO.Service.Interfaces.IOrganisations;
using System.Linq.Expressions;

namespace INNO.Service.Services
{
    public class OrganisationAppService : IOrganisationAppService
    {
        private readonly IGenericRepository<OrganizationApps> _repository;

        public OrganisationAppService(IGenericRepository<OrganizationApps> repository)
        {
            this._repository = repository;
        }
        public Task<OrganizationApps> CreatAsync(OrganizationApps organizationApp)
        {

            throw new NotImplementedException();
        }

        public Task<OrganizationApps> Delete(Expression<Func<OrganizationApps, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<OrganizationApps> GetAllAsync(PaginationParams @params, Expression<Func<OrganizationApps, bool>> expression = null)
        {
            throw new NotImplementedException();
        }

        public Task<OrganizationApps> UpdateAsync(OrganizationApps organizationApp)
        {
            throw new NotImplementedException();
        }
    }
}
