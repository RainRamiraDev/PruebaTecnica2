using PruebaTecnica.Dto;
using PruebaTecnica.Models;
using PruebaTecnica.Response;

namespace PruebaTecnica.Interfaces.Services
{
    public interface IUserService
    {
        Task<ApiResponse<List<UserDbReadDto>>> GetAll();
        Task<ApiResponse<UserDbReadDto>> GetById(int id);
        Task<ApiResponse<UserDbReadDto>> Post(UserDbAlterDto userDto);
        Task<User> Update(int id, UserDbAlterDto usuarioDto);
        Task Delete(int id);

    }
}
