using Controle_de_Contatos_2.Models;

namespace Controle_de_Contatos_2.Helper
{
    public class Sessao : ISessao
    {
        private readonly IHttpContextAccessor _httpContext;
        public Sessao(IHttpContextAccessor httpContext)
        {
            _httpContext = httpContext;  
        }
        public UsuarioModel BuscarSessaoDoUsuario()
        {
            throw new NotImplementedException();
        }

        public void CriarSessaoDoUsuario(UsuarioModel usuario)
        {
            string valor = JsonContent.SerializeObject(usuario);
            _httpContext.HttpContext.Session.SetString("SessaoUsuarioLogado", valor);
        }

        public void RemoverSessaoDoUsuario()
        {
            throw new NotImplementedException();
        }
    }
}
