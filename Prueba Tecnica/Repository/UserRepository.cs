using Microsoft.EntityFrameworkCore;
using PruebaTecnica.Data;
using PruebaTecnica.Interfaces.Repository;
using PruebaTecnica.Models;

namespace PruebaTecnica.Repository
{
    public class UserRepository : IUserRepository
    {

        private readonly ContextDb _context;

        public UserRepository(ContextDb context)
        {
            _context = context;
        }
        public async Task<List<User>> GetAll()
        {
            var Usuarioss = await _context.Usuarios
                .ToListAsync();
            return Usuarioss;
        }

        public async Task<User> GetById(int id)
        {
            var Usuarios = await _context.Usuarios
                .FirstOrDefaultAsync(e => e.Id == id);
            return Usuarios;
        }

        public async Task Post(User Usuarios)
        {
            await _context.Usuarios.AddAsync(Usuarios);
            await _context.SaveChangesAsync();
        }

        public async Task<User> Update(User usuario)
        {
            _context.Usuarios.Update(usuario);
            await _context.SaveChangesAsync();
            return usuario;
        }

        public async Task Delete(int id)
        {
            var user = await _context.Usuarios.FindAsync(id);
            if (user != null)
            {
                _context.Usuarios.Remove(user);
                await _context.SaveChangesAsync();
            }
        }




        
    }
}
