using Controle_de_Contatos_2.Data;
using Controle_de_Contatos_2.Models;

namespace Controle_de_Contatos_2.Repositorio
{
    public class ContatoRepositorio : IContatoRepositorio
    { 
        private readonly BancoContext _bancoContext;
        public ContatoRepositorio(BancoContext bancoContext)
        {
                _bancoContext = bancoContext;
        }
        public List<ContatoModel> BuscarTodos()
        {
            return _bancoContext.Contatos.ToList();

        }
        public ContatoModel Adicionar(ContatoModel contato)
        {
            _bancoContext.Contatos.Add(contato);
            _bancoContext.SaveChanges();
            return contato;
            
        }

        
    }
}
