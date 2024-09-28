using AutoMapper;
using PruebaTecnica.Dto;
using PruebaTecnica.Interfaces.Repository;
using PruebaTecnica.Interfaces.Services;
using PruebaTecnica.Models;
using PruebaTecnica.Response;
using System.Net;

namespace PruebaTecnica.Service
{
    public class UserService : IUserService
    {

        
       private readonly IUserRepository _userRepository;
       private readonly IMapper _mapper;

       public UserService(IUserRepository userRepository, IMapper mapper)
       {
           _userRepository = userRepository;
           _mapper = mapper;
       }

       

        public async Task<ApiResponse<List<UserDto>>> GetAll()
       {
           var response = new ApiResponse<List<UserDto>>();

           try
           {
               var users = await _userRepository.GetAll();
               var usersDto = _mapper.Map<List<UserDto>>(users);

               if (users.Count == 0)
               {
                   response.SetError("No se encontro nada!", HttpStatusCode.NotFound);
                   return response;
               }

               response.Data = usersDto;
               return response;
           }
           catch (Exception e)
           {
               response.SetError(e.Message, HttpStatusCode.BadRequest);
               return response;
           }
       }

     

       public async Task<ApiResponse<UserDto>> GetById(int id)
       {
           var response = new ApiResponse<UserDto>();

           try
           {
               var user = await _userRepository.GetById(id);
               if (user == null)
               {
                   response.SetError("No se encontro!", HttpStatusCode.NotFound);
                   return response;
               }

               var userDto = _mapper.Map<UserDto>(user);
               response.Data = userDto;
               return response;
           }
           catch (Exception e)
           {
               response.SetError(e.Message, HttpStatusCode.BadRequest);
               return response;
           }
       }

       

       public async Task<ApiResponse<UserDto>> Post(UserDto userDto)
       {
           var response = new ApiResponse<UserDto>();

           try
           {
               var user = _mapper.Map<User>(userDto);
               await _userRepository.Post(user);
               response.Data = userDto;
               return response;
           }
           catch (Exception e)
           {
               response.SetError(e.Message, HttpStatusCode.BadRequest);
               return response;
           }
       }

        public async Task<User> Update(int id, UpdateUserDto usuarioDto)
        {
            // Buscar el usuario existente por id
            var existingUser = await _userRepository.GetById(id);
            if (existingUser == null)
            {
                throw new Exception("User not found");
            }

            // Mapear las propiedades de usuarioDto a existingUser
            _mapper.Map(usuarioDto, existingUser);

            // Guarda los cambios en el repositorio
            return await _userRepository.Update(existingUser);
        }


        public async Task Delete(int id)
        {
            await _userRepository.Delete(id);
        }
    }
}
