using Microsoft.EntityFrameworkCore;
using PruebaTecnica.Models;

//using PruebaTecnica.Models;
using System.Threading;

namespace PruebaTecnica.Data;

public class ContextDb : DbContext
{
    public ContextDb(DbContextOptions<ContextDb> options) : base(options)
    {
    }

    public DbSet<User> Usuarios { get; set; }




}