using ApiContacto.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiContacto.Context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            :base(options) { }
      
        public DbSet<Persona> Personas => Set<Persona>();

    }
}
