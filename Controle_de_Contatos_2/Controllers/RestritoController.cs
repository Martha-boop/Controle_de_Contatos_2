using Controle_de_Contatos_2.Filters;
using Microsoft.AspNetCore.Mvc;

namespace Controle_de_Contatos_2.Controllers
{
    public class RestritoController : Controller
    {
        [PaginaParaUsuarioLogado]
        public IActionResult Index()
        {
            return View();
        }
    }
}
