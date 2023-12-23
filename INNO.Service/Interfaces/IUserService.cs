using INNO.Data.IRepositories;
using INNO.Domain.Entities.Users;
using INNO.Service.DTOs.Users;
using System.Linq.Expressions;
using System.Reflection.Emit;

namespace INNO.Service.Interfaces
{
    public interface IUserService
    {
        public Task<UserForViewDTO> CreateAsync(UserForCreationDTO user);
        public Task<UserForViewDTO> UpdateAsync(UserForUpdateDTO user);
        public Task<bool> DeleteAsync(string email);
        public Task<UserForViewDTO> GetByIdAsync(Expression<Func<UserForViewDTO,bool>> expression);
        public Task<ICollection<UserForViewDTO>> GetAsync(Expression<Func<UserForViewDTO, bool>> expression);
    }
}
