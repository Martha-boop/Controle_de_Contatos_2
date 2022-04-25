using System.ComponentModel.DataAnnotations;

namespace Controle_de_Contatos_2.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Digite o Login")]
        public string Login { get; set; }


        [Required(ErrorMessage = "Digite a Senha")]
        public string Senha { get; set; }
    }
}
