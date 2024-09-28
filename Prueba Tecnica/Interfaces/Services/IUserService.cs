using PruebaTecnica.Dto;
using PruebaTecnica.Models;
using PruebaTecnica.Response;

namespace PruebaTecnica.Interfaces.Services
{
    public interface IUserService
    {

        //Task<ApiResponse<List<UserDto>>> GetAll();
        //Task<ApiResponse<UserDto>> GetById(int id);
        //Task<ApiResponse<UserDto>> Post(UserDto userDto);
        //Task<User> Update(int id, UserDbReadDto usuarioDto);
        //Task Delete(int id);

        Task<ApiResponse<List<UserDbReadDto>>> GetAll();
        Task<ApiResponse<UserDbReadDto>> GetById(int id);
        Task<ApiResponse<UserDbReadDto>> Post(UserDbAlterDto userDto);
        Task<User> Update(int id, UserDbAlterDto usuarioDto);

        Task Delete(int id);

    }
}
