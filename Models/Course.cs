namespace Registrar.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Number { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int Credits { get; set; }

        public List<Student> Students { get; set; } = new List<Student>();

    }
}