using Microsoft.EntityFrameworkCore;

namespace HospiEnCasa.App.Persistencia
{
   public class AppContext : DbContext 
   {
       //public DbSet<Persona> Persona {get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
                /*if (!optionsBuilder.IsConfigured)
                {
                    optionsBuilder
                    .UseSqlserver("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog =dd");

                }*/
        }
   }
}