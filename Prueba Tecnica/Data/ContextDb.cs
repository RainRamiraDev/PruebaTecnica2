using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using PruebaTecnica.Models;
using System.Threading;

namespace PruebaTecnica.Data;

public class ContextDb : DbContext
{
    public ContextDb(DbContextOptions<ContextDb> options) : base(options)
    {

		try
		{
			var databaseCreator = Database.GetService<IDatabaseCreator>() as RelationalDatabaseCreator;
			if (databaseCreator != null)
			{
                if (!databaseCreator.CanConnect())
                    databaseCreator.Create();

                if (!databaseCreator.HasTables())
                    databaseCreator.CreateTables();
            }

		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}

    }

    public DbSet<User> Usuarios { get; set; }


   

}