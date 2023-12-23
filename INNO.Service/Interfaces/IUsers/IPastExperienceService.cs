using INNO.Domain.Configuration;
using INNO.Domain.Entities.Organizations;
using INNO.Domain.Entities.Users;
using INNO.Service.DTOs.Organizations;
using INNO.Service.DTOs.PastExperiences;
using System.Linq.Expressions;

namespace INNO.Service.Interfaces.IUsers;
public interface IPastExperienceService
{
    public Task<PastExperienceForViewDTO> CreateAsync(PastExperienceForCreationDTO Past);

    public Task<PastExperienceForViewDTO> UpdateAsync(PastExperienceForUpdateDTO PastUpdate);

    public Task<bool> DeleteAsync(Expression<Func<PastExperience, bool>> expression);

    public Task<PastExperienceForViewDTO> GetByIdAsync(Expression<Func<PastExperience, bool>> expression);
    public Task<ICollection<PastExperienceForViewDTO>> GetAsync(PaginationParams @params,
        Expression<Func<PastExperience, bool>> expression);


}
