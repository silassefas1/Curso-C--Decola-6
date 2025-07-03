using Microsoft.AspNetCore.Mvc;

namespace PrimeiroMVC.Controllers
{
    public class ProdutosController : Controller //define o clontoler como um controlador MVC
    {
        public IActionResult Index() // o index é o nome padrao para a rota
        {
            return View(); //retprma a rota para a view, a rota fica dentro da pasta do controller Views/Produtos/Index.cshtml
        }
        // toda view para aparecer na pagina precisa estar dentro do _Layout.cshtml que fica na pasta Views/Shared
        public IActionResult Clientes() { 
        
            return View();
        }
    }
}
