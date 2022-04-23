using Controle_de_Contatos_2.Models;

namespace Controle_de_Contatos_2.Repositorio
{
    public interface IContatoRepositorio
    {
        List<ContatoModel> BuscarTodos();
        ContatoModel Adicionar(ContatoModel contato);
        
    }
}
