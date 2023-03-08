namespace Registrar.Models
{
    public class RegistrarContext : DbContext
    {
        public RegistrarContext(DbContextOptions<RegistrarContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}