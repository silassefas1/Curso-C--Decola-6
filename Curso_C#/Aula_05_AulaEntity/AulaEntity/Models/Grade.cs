using System.ComponentModel.DataAnnotations;

namespace AulaEntity.Models
{
    public class Grade
    {
        [Key]
        public int GradeId { get; set; }
        public string? GradeName { get; set; }

        //Navigation property to the related students
        public ICollection<Student>? Students { get; set; } = new List<Student>();
    }
}

