using Controle_de_Contatos_2.Models;
using Microsoft.EntityFrameworkCore;

namespace Controle_de_Contatos_2.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
        }
        public DbSet<ContatoModel> Contatos { get; set; }
        public DbSet<UsuarioModel> Usuarios { get; set; }

    }
}

