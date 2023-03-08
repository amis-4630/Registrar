using Microsoft.EntityFrameworkCore;
namespace Registrar.Models
{
    public class RegistrarContext : DbContext
    {
        public RegistrarContext(DbContextOptions<RegistrarContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; } = null!;
        public DbSet<Course> Courses { get; set; } = null!;
        public DbSet<Enrollment> Enrollments { get; set; } = null!;
    }
}