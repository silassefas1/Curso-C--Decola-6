using AulaEntity.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AulaEntity.Controllers
{
    public class TurmasController : Controller
    {
        private readonly AulaEntityContext _context;

        public TurmasController(AulaEntityContext context)
        {
            _context = context;
        }

        // GET: Turmas/ALunosPorTurma/1

        public IActionResult AlunosPorTurma(int id)
        {
            var turma = _context.Grade
                .Include(g => g.Students)
                .FirstOrDefault(g => g.GradeId == id);
            if (turma == null)
            {
                return NotFound();
            }
            return View(turma);
        }

        public IActionResult Index()
        {
            var turmas = _context.Grade
                .Include(g => g.Students)
                .ToList();
            return View(turmas);
        }
    }
}

