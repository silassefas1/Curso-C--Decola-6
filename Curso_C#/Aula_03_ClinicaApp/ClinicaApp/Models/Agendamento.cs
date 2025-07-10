using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace ClinicaApp.Models
{
    public class Agendamento
    {
        [Key]
        public int AgendamentoID { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public string Cliente { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public string Especialidade { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public string Medico { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public DateTime DataConsulta { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public string TipoAtendimento { get; set; }

    }
}
