﻿using Controle_de_Contatos_2.Enuns;
using Controle_de_Contatos_2.Helper;
using System.ComponentModel.DataAnnotations;

namespace Controle_de_Contatos_2.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "Digite o nome do usuario")]
        public string Nome { get; set; }


        [Required(ErrorMessage = "Digite o login do usuario")]
        public string Login { get; set; }


        [Required(ErrorMessage = "Digite o e-mail do usuario")]
        [EmailAddress(ErrorMessage = "O e-mail informado não é valido!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Digite o perfil do usuario")]
        public PerfilEnum? Perfil { get; set; }


        [Required(ErrorMessage = "Digite a senha do usuario")]
        public string Senha { get; set; }


        public DateTime DataCadastro { get; set; }
        public DateTime? DataAtualizacao  { get; set; }

        public bool SenhaValida(string senha)
        {
            return Senha == senha.GerarHash();
        }
        public void SetSenhaHash()
        {
            Senha = Senha.GerarHash();
        }
        public  string GerarNovaSenha()
        {
            string  novaSenha = Guid.NewGuid().ToString().Substring( 0,8);
            Senha = novaSenha.GerarHash();
            return novaSenha;
        }
    }
}
