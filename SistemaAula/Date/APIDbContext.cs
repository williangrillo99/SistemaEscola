using Microsoft.EntityFrameworkCore;
using SistemaAula.Entidades;

namespace SistemaAula.Date
{
    public class APIDbContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        
        public APIDbContext(DbContextOptions<APIDbContext> options) : base(options) { } 
        

    }
}
