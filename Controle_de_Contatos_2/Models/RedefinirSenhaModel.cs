﻿using System.ComponentModel.DataAnnotations;

namespace Controle_de_Contatos_2.Models
{
    public class RedefinirSenhaModel
    {

        [Required(ErrorMessage = "Digite o Login")]
        public string Login { get; set; }


        [Required(ErrorMessage = "Digite o e-mail")]
        public string Email { get; set; }
    }
}
