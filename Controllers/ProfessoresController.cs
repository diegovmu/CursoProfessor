using Microsoft.AspNetCore.Mvc;
using CursoProfessor.Models;
using CursoProfessor.ViewModel;
using CursoProfessor.Repository;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;
using CursoProfessor.Services;

namespace CursoProfessor.Controllers
{
    [ApiController]
    [Route("professres")]
    public class ProfessoresController : ControllerBase
    {
        private AplicationDbContext _context = new AplicationDbContext();

        [HttpPost]
        public IActionResultDbContext AdicionarProfessor([FromBody]LerProfessor professor)
        {
            Professor professor = new Professor
            {
                NomeProfessor = LerProfessor.NomeProfessor,
                Curso = professor.Curso,
            }
            _context.TabelaDeProfessores.Add(professor);
            _context.SaveChanges();
            return Created("professor", professor);
        }


        [HttpGet]
        public IActionResult ObterProfessor()
        {
            return Ok(_context.TabelaDeProfessores);
        }
        [HttpGet("{id}")]
        public IActionResult ObterProfessorPorId(Guid id)
        {
            Professor professor = _context.TabelaDeProfessores.FirstOrDefault(professor => professor.Id == id);
            if (professor != null)
            {
                LerProfessor  new LerProfessor
                {
                    NomeProfessor = professor.NomeProfessor,
                    Curso = professor.Curso,
                    Id = professor.Id,
                    MomentoDaConsulta = DateTime.Now
                };
                return Ok(professor);
            }
            return NotFound()
        }

        [HttpPut("{id}")]
        public IActionResult AtualizarProfessor(Guid id, [FromBody] UpdateProfessor professorDto)
        {
            Professor professor = _context.TabelaDeProfessores.FirstOrDefault(professor => professor.Id == id);
            if (professor == null)
            {
                return NotFound();
            }
            professor.NomeProfessor = professorDto.NomeProfessor;
            professor.Curso = professorDto.Curso;
            _context.SaveChanges();
            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult DeletarProfessor(Guid id)
        {
            Professor professor = _context.TabelaDeProfessores.FirstOrDefault(professor => professor.Id == id);
            if (professor == null)
            {
                return NotFound();
            }
            _context.Remove(professor);
            _context.SaveChanges();
            return NoContent();
        }


    }
}
