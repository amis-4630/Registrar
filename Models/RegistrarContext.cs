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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // use a composite key for the enrollment entity    
            modelBuilder.Entity<Enrollment>()
                .HasKey(e => new { e.StudentId, e.CourseId });

            // owned entity type for address with 
            modelBuilder.Entity<Student>()
            .OwnsOne(s => s.PrimaryAddress);

        }


    }
}