using Controle_de_Contatos_2.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Controle_de_Contatos_2.ViewComponents
{
    public class Menu : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            string sessaoUsuario = HttpContext.Session.GetString("SessaoUsuarioLogado");
            UsuarioModel usuario = JsonConvert.DeserializeObject<UsuarioModel>(sessaoUsuario);
            return View(usuario);
        }
            
    }
}
