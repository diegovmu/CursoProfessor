using Microsoft.AspNetCore.Mvc;
using CursoProfessor.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace CursoProfessor.Services
{
    public class LerCurso : Cursos
    {
        public DateTime MomentoDaConsulta { get; set; }
    }
}
