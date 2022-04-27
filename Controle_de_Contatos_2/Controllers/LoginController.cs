using Controle_de_Contatos_2.Helper;
using Controle_de_Contatos_2.Models;
using Controle_de_Contatos_2.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace Controle_de_Contatos_2.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        private readonly ISessao _sessao;
        public LoginController(IUsuarioRepositorio usuarioRepositorio,
                                    ISessao sessao)
                               
        {
            _usuarioRepositorio = usuarioRepositorio; 
            _sessao = sessao;
        }
        public IActionResult Index()
        {
            // se o usuario estiver logado redirecionar para a Home.
            if (_sessao.BuscarSessaoDoUsuario() != null) return RedirectToAction("Index" ,"Home");
            return View();
        }
        public IActionResult Sair()
        {
            _sessao.RemoverSessaoDoUsuario();
            return RedirectToAction("Index", "Login");
        }
        [HttpPost]
        public IActionResult Entrar(LoginModel loginModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    UsuarioModel usuario = _usuarioRepositorio.BuscarPorlogin(loginModel.Login);
                    if (usuario != null)
                    {
                        if (usuario.SenhaValida(loginModel.Senha))
                        {
                            _sessao.CriarSessaoDoUsuario(usuario);
                            return RedirectToAction("Index", "Home");
                        }
                        TempData["MensagemErro"] = $" Senha do Usuario é inavalida. Por favor tente novamente.";
                    }
                    TempData["MensagemErro"] = $"Usuario e/ou senha inavalida. Por favor tente novamente.";
                }
                return View("Index");
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Ops! não conseguimos realizar seu login,tente novamente,detalhe do erro:{erro.Message}";
                return RedirectToAction("Index");
            }
        }
    }
    
  
}
