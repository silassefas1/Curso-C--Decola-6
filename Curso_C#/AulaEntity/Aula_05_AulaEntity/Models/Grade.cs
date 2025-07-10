using System.ComponentModel.DataAnnotations;

namespace Aula_05_AulaEntity.Models;

public class Grade
{
    [Key]
    public int GradeId { get; set; }
    public string Name { get; set; }
    
    //propriedade de navegação
    public ICollection<Student> Students { get; set; }
    
}