using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace CursoProfessor.Models
{
    public class Professor
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo NomeDoProfessor é obrigatorio")]
        public string NomeProfessor { get; set; }
        public string Curso { get; set; }

        public Professor()
        {
            Id = Guid.NewGuid();
        }
    }
}
