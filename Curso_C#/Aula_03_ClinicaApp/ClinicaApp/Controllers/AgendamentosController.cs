using ClinicaApp.Data;
using ClinicaApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClinicaApp.Controllers
{
    public class AgendamentosController : Controller
    {
        private readonly ClinicaContext _context;

        public AgendamentosController(ClinicaContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Agendamento agendamentos)
        {
            
            _context.Agendamentos.Add(agendamentos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }

    }
}
