using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace CursoProfessor.Models
{
    public class Cursos
    {
        [key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        public string NomeDoCurso { get; set; }

        [Range(ErrorMessage = "A duração minima é de 1h e a máxima de 100h")]
        public int Duracao { get; set; }
        public Curso()
        {
            Id = Guid.NewGuid();
        }
    }
}
