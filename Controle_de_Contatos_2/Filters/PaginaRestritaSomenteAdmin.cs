using Controle_de_Contatos_2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;

namespace Controle_de_Contatos_2.Filters
{
    public class PaginaRestritaSomenteAdmin : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            string SessaoUsuario = context.HttpContext.Session.GetString("SessaoUsuarioLogado");
            if (string.IsNullOrEmpty(SessaoUsuario))
            {
                context.Result = new RedirectToRouteResult(new RouteValueDictionary
                { { "controller", "Login" }, { "action", "Index" } });
            }
            else
            {
                UsuarioModel usuario = JsonConvert.DeserializeObject<UsuarioModel>(SessaoUsuario);
                if (usuario == null)
                {
                    context.Result = new RedirectToRouteResult(new RouteValueDictionary
                  { { "controller", "Login" }, { "action", "Index" } });

                }
                if (usuario.Perfil != Enuns.PerfilEnum.Admin)
                {
                    context.Result = new RedirectToRouteResult(new RouteValueDictionary
                  { { "controller", "Restrito" }, { "action", "Index" } });
                }

            }
            base.OnActionExecuting(context);
        }
        
            
        
    }
}
