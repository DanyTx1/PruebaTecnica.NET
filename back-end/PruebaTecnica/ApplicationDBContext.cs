using Microsoft.EntityFrameworkCore;

namespace PruebaTecnica
{
    public class ApplicationDBContext : DbContext
    {

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }

        public DbSet<models.Alumno> Alumnos { get; set; }

    }
    
}
