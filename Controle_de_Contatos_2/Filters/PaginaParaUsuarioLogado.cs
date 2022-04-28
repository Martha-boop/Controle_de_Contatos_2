using Microsoft.AspNetCore.Mvc.Filters;

namespace Controle_de_Contatos_2.Filters
{
    public class PaginaParaUsuarioLogado : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);
        }
        
            
        
    }
}
