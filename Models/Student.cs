namespace Registrar.Models;

public class Student
{
    public int Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public Address PrimaryAddress { get; set; } = null!;
    public List<Enrollment> Enrollments { get; set; } = new List<Enrollment>();

}