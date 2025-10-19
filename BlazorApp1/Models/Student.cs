using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        [MinLength(3,ErrorMessage ="Name must be greater than 3 char")]
        public string Name  { get; set; }
        [Required]
        [MaxLength(100)]
        [MinLength(5, ErrorMessage = "Address must be greater than 3 char")]
        public string  Address { get; set; }
        public int DepartId { get; set; }

        public override string ToString()
        {
            return $"Name: {Name} - Address: {Address}";
        }
    }
}
