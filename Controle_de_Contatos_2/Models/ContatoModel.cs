using System.ComponentModel.DataAnnotations;

namespace Controle_de_Contatos_2.Models
{
    public class ContatoModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Digite o nome do contato")]
        public string Nome  { get; set; }
        [Required(ErrorMessage ="Digite o e-mail do contato")]
        [EmailAddress(ErrorMessage ="O e-mail informado não é valido!")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Digite o celular do contato")]
        [Phone(ErrorMessage ="O telefone informado não é valido!")]
        public  string  Celular { get; set; }
    }
}
