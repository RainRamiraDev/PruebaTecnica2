using PruebaTecnica.Dto;
using PruebaTecnica.Models;
using PruebaTecnica.Response;

namespace PruebaTecnica.Interfaces.Services
{
    public interface IUserService
    {

       Task<ApiResponse<List<UserDto>>> GetAll();
       Task<ApiResponse<UserDto>> GetById(int id);
       Task<ApiResponse<UserDto>> Post(UserDto userDto);
       Task<User> Update(int id, UpdateUserDto usuarioDto);
       Task Delete(int id);

    }
}
