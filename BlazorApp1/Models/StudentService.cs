namespace BlazorApp1.Models
{
    public class StudentService
    {
        private List<Student> Students;
        public StudentService()
        {

            Students = new List<Student>
            {
            new Student { Id = 1, Name = "Ahmed", Address = "Cairo", DepartId = 1 },
            new Student { Id = 2, Name = "Mona", Address = "Alexandria", DepartId = 2 },
            new Student { Id = 3, Name = "Khaled", Address = "Giza", DepartId = 1 },
            new Student { Id = 4, Name = "Sara", Address = "Tanta", DepartId = 3 },
            new Student { Id = 5, Name = "Youssef", Address = "Aswan", DepartId = 2 }
            };
        }

        public List<Student> getAll()
        {
            return Students;
        }
        public Student? getById(int Id)
        {
            return Students.FirstOrDefault(x => x.Id == Id);
        }
    }
}
