using ClinicaApp.Data;
using ClinicaApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ClinicaApp.Controllers
{
    public class ClientesController : Controller
    {

        //Campo privado para armazenar o contexto do DB
        private readonly ClinicaContext _context;

        //construtor que recebe o contexto do DB

        public ClientesController(ClinicaContext context)
        {
            _context = context;
        }
        
        

        //GET - sempre que não tiver é get
        //Task - Faz executar as tarefas de forma assincrona
        public async Task<IActionResult> Index()
        {
            var clientes = await _context.Clientes.ToListAsync();
            return View(clientes);
        }

      
        public IActionResult Create()
        {
            return View();
        }

        // POST: Clientes/Create
        // Ação que recebe os dados do formulário e os salva no banco.
        [HttpPost] // Este atributo especifica que a ação responde apenas a requisições POST.
        [ValidateAntiForgeryToken] // Atributo de segurança para previnir ataques CSRF.
        public async Task<IActionResult> Create([Bind("Nome,DataNascimento,Salario")]Cliente cliente)
        {
            _context.Clientes.Add(cliente); // Adiciona o cliente ao contexto do banco de dados
            await _context.SaveChangesAsync(); // Salva as alterações no banco de dados, pode tirar o awayt e o Async para fazer sincrono e usar o return de baixo
            //return Task.FromResult<IActionResult>(RedirectToAction(nameof(Index))); // Redireciona para a lista de clientes
            return RedirectToAction(nameof(Index));
        }

        private bool ClienteExists(int id)
        {
           return _context.Clientes.Any(e => e.ClienteID == id);
        }



        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente = await _context.Clientes.FindAsync(id);
            if (cliente == null)
            {
                return NotFound();
            }
            return View(cliente);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ClienteID,Nome,DataNascimento,Salario")] Cliente cliente)
        {
            if (!ClienteExists((cliente.ClienteID))) // Verifica se o ID do cliente passado é igual ao ID do cliente que está sendo editado
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try { 
                    _context.Clientes.Update(cliente); // Atualiza o cliente no contexto do banco de dados  
                    await _context.SaveChangesAsync(); // Salva as alterações no banco de dados
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClienteExists(cliente.ClienteID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
            }
            return RedirectToAction(nameof(Index)); // Redireciona para a lista de clientes
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var cliente = await _context.Clientes.FindAsync(id);
            if (cliente == null)
            {
                return NotFound();
            }
            return View(cliente);
        }

        // POST: Clientes/Delete/{id}
        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var cliente = await _context.Clientes.FindAsync(id);
            if (cliente != null)
            {
                _context.Clientes.Remove(cliente);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
 