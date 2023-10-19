using Microsoft.EntityFrameworkCore;
using MyGardenPlanner.Models;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;

namespace MyGardenPlanner.Data
{
    public class GardenContext : DbContext
    {
        public GardenContext(DbContextOptions<GardenContext> dbContextOptions) : base(dbContextOptions) 
        {
            try 
            {
                var databaseCreator = Database.GetService<IDatabaseCreator>() as RelationalDatabaseCreator;
                if (databaseCreator != null)
                {
                    if (!databaseCreator.CanConnect()) databaseCreator.Create();
                    if (!databaseCreator.HasTables()) databaseCreator.CreateTables();
                }
            } 
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
        }

        public DbSet<Garden> Garden { get; set; }
        public DbSet<Plant> Plant { get; set; }
        public DbSet<PlantCategory> PlantCategory { get; set; }
    }
}
