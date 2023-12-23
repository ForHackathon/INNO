using INNO.Data.IRepositories;
using INNO.Domain.Configuration;
using INNO.Domain.Entities.Users;
using INNO.Service.DTOs.Users;
using System.Linq.Expressions;
using System.Reflection.Emit;

namespace INNO.Service.Interfaces
{
    public interface IUserService
    {
        public Task<UserForViewDTO> CreateAsync(UserForCreationDTO user);
        public Task<UserForViewDTO> UpdateAsync(long id,UserForUpdateDTO user);
        public Task<bool> DeleteAsync(Expression<Func<User,bool>> expression);
        public Task<UserForViewDTO> GetByIdAsync( Expression<Func<User,bool>> expression);
        public Task<ICollection<UserForViewDTO>> GetAsync(PaginationParams @params, Expression<Func<User, bool>> expression);
        public Task<bool> ChangePasswordAsync(UserForChangePasswordDTO userForChangePasswordDTO);

    }
}
