using System.ComponentModel.DataAnnotations;

namespace CursoProfessor.Services
{
    public class ProfessoresService
    {
        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        public string NomeProfessor { get; set; }
        public string Curso { get; set; }
       
    }
}
