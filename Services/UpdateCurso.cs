using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace CursoProfessor.Services
{
    public class UpdateCurso : Controller
    {
        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        public string NomeDoCurso { get; set; }

        [Range(1, 100, ErrorMessage = "A duração minima é de 1H e a máxima de 100H")]
        public int Duracao { get; set; }
    }  
}
