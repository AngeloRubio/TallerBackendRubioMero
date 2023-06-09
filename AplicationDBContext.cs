using Microsoft.EntityFrameworkCore;
using TallerBackendRubioMero.models;

namespace TallerBackendRubioMero
{
    public class AplicationDBContext : DbContext
    {
        public AplicationDBContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

    }
}
