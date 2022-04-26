using Controle_de_Contatos_2.Models;

namespace Controle_de_Contatos_2.Repositorio
{
    public interface IUsuarioRepositorio
    {
        UsuarioModel BuscarPorlogin(string login);
        UsuarioModel ListarPorId(int id);
        List<UsuarioModel> BuscarTodos();
        UsuarioModel Adicionar(UsuarioModel usuario);
        UsuarioModel Atualizar(UsuarioModel usuario);
        bool Apagar(int id);
    }
}
