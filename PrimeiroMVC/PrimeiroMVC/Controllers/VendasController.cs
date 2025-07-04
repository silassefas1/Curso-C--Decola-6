using Microsoft.AspNetCore.Mvc;

namespace PrimeiroMVC.Controllers
{
    public class VendasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Vendas()
        {
            return View();
        }
    }
}
