using BlazorApp1.Models;

public class SampleData
{
    private List<Depat> Depats;
    private List<Student> Students;

    public SampleData()
    {
        Depats = new List<Depat>
        {
            new Depat { Id = 1, Name = "Computer Science" },
            new Depat { Id = 2, Name = "Information Systems" },
            new Depat { Id = 3, Name = "Software Engineering" }
        };

        Students = new List<Student>
        {
            new Student { Id = 1, Name = "Ahmed", Address = "Cairo", DepartId = 1 },
            new Student { Id = 2, Name = "Mona", Address = "Alexandria", DepartId = 2 },
            new Student { Id = 3, Name = "Khaled", Address = "Giza", DepartId = 1 },
            new Student { Id = 4, Name = "Sara", Address = "Tanta", DepartId = 3 },
            new Student { Id = 5, Name = "Youssef", Address = "Aswan", DepartId = 2 }
        };
    }

    public List<Student> GetStudents()
    {
        return Students;
    }

    public List<Depat> GetDepats()
    {
        return Depats;
    }
}
