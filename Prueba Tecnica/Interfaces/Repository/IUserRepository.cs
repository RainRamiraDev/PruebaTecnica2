using PruebaTecnica.Dto;
using PruebaTecnica.Models;

namespace PruebaTecnica.Interfaces.Repository
{
    public interface IUserRepository
    {
     Task<List<User>> GetAll();
     Task<User> GetById(int id);
     Task Post(User usuario);
     Task<User> Update(User usuario);
     Task Delete(int id);

    }
}
