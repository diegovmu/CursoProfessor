using CursoProfessor.Models;
using CursoProfessor.Respository;
using CursoProfessor.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoProfessor.Services
{
    public classs CursosServices
    {
        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        public string NomeDoCurso { get; set; }

        [Range(1, 100, ErrorMessage = "A duração minima é de 1H e a máxima de 100H")]
        public int Duracao { get; set; }


    }
}