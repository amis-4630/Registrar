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

        // protected override void OnModelCreating(ModelBuilder builder)
        // {
        //     builder.Entity<Student>()
        //         .OwnsOne(s => s.PrimaryAddress);

        //     builder.Entity<Student>().HasData(
        //         new Student
        //         {
        //             Id = 1,
        //             FirstName = "John",
        //             LastName = "Doe",
        //             PrimaryAddress = new Address
        //             {
        //                 Street = "123 Main St",
        //                 City = "Portland",
        //                 State = "OR",
        //                 ZipCode = "97201"
        //             }
        //         },
        //         new Student
        //         {
        //             Id = 2,
        //             FirstName = "Jane",
        //             LastName = "Doe",
        //             PrimaryAddress = new Address
        //             {
        //                 Street = "456 Main St",
        //                 City = "Portland",
        //                 State = "OR",
        //                 ZipCode = "97201"
        //             }
        //         },
        //         new Student
        //         {
        //             Id = 3,
        //             FirstName = "John",
        //             LastName = "Smith",
        //             PrimaryAddress = new Address
        //             {
        //                 Street = "101 Main St",
        //                 City = "Portland",
        //                 State = "OR",
        //                 ZipCode = "97201"
        //             }
        //         },
        //         new Student
        //         {
        //             Id = 4,
        //             FirstName = "Jane",
        //             LastName = "Smith",
        //             PrimaryAddress = new Address
        //             {
        //                 Street = "202 Main St",
        //                 City = "Portland",
        //                 State = "OR",
        //                 ZipCode = "97201"
        //             }
        //         }
        //     );

        //     builder.Entity<Course>().HasData(
        //         new Course
        //         {
        //             Id = 1,
        //             Name = "Intro to Programming",
        //             Number = "C# 101",
        //             Description = "Learn the basics of C#",
        //             Credits = 3
        //         },
        //         new Course
        //         {
        //             Id = 2,
        //             Name = "Intermediate Programming",
        //             Number = "C# 201",
        //             Description = "Learn more advanced C#",
        //             Credits = 3
        //         },
        //         new Course
        //         {
        //             Id = 3,
        //             Name = "Advanced Programming",
        //             Number = "C# 301",
        //             Description = "Learn the most advanced C#",
        //             Credits = 3
        //         }
        //     );
        // }
    }
}