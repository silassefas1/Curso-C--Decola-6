using System.ComponentModel.DataAnnotations;

namespace ClinicaApp.Models
{
    public class Cliente
    {
        //CODE FIRST -- criar o banco do codigo
        [Key]
        [Display(Name = "ID Do Cliente")]
        public int ClienteID { get; set; }
        
        [Required]
        [MaxLength(50)]
        [Display(Name = "Nome")]
        public string Nome { get; set; }
        
        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }

        [Display(Name = "Valor do Salário")]
        public decimal Salario { get; set; }

    }
}
