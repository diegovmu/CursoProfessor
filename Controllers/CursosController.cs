using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CursoProfessor.Services;
using Microsoft.Extensions.Logging;
using CursoProfessor.Models;
using CursoProfessor.Respository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoProfessor.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CursoController : ControllerBase
    {
        private AplicationDbContext _context = new AplicationDbContext();

        [HttpPost]
        public IActionResult AdicionarCurso([FromBody] CursosService)
        {
            Curso curso = new Curso
            {
                NomeDoCurso = CursosService.NomeDoCurso;
                Duracao = CursosService.Duracao;
            };
            _context.TabelaDeCursos.Add(curso);
            _context.SaveChanges();
            return Created("curso", curso);
        }

        [HttpGet]
        public IActionResult ObterCurso()
        {
            return Ok(_context.TabelaDeCursos);
        }

        [HttpGet("{id}")]
        public IActionResult ObterCursosPorId(Guid id)
        {
            Curso curso = _context.TabelaDeCursos.FirstOrDefault(curso => curso.Id == id);
            if (curso != null)
            {
                LerCurso = new LerCurso.NomeDoCurso;
                {
                    NomeDoCurso = curso.NomeDoCurso,
                    Duracao = curso.Duracao,
                    Id = curso.Id,
                    MomentoDaConsulta = DateTime.Now
                };
                return Ok(cursoDto);
            }
            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult AtualizarCurso(Guid id, [FromBody] UpdateCursoDto cursoDto)
        {
            Curso curso = _context.TabelaDeCursos.FirstOrDefault(curso => curso.Id == id);
            if (curso == null)
            {
                return NotFound();
            }
            curso.NomeDoCurso = curso.NomeDoCurso;
            curso.Duracao = curso.Duracao;
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletarCurso(Guid id)
        {
            Curso curso = _context.TabelaDeCursos.FirstOrDefault(curso => curso.Id == id);
            if (curso == null)
            {
                return NotFound();
            }
            _context.Remove(curso);
            _context.SaveChanges();
            return NoContent();
        }

    }
}
