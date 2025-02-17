﻿using Controle_de_Contatos_2.Filters;
using Controle_de_Contatos_2.Models;
using Controle_de_Contatos_2.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace Controle_de_Contatos_2.Controllers
{
    [PaginaParaUsuarioLogado]
    public class ContatoController : Controller
    {
        private readonly IContatoRepositorio _contatoRepositorio;
        public ContatoController(IContatoRepositorio contatoRepositorio)
        {
            _contatoRepositorio = contatoRepositorio;
        }
        public IActionResult Index()
        {
            List<ContatoModel> contatos = _contatoRepositorio.BuscarTodos();
            return View(contatos);
        }
        public IActionResult Criar()
        {
            return View();
        }
        public IActionResult Editar(int id)
        {
          ContatoModel contato =  _contatoRepositorio.ListarPorId(id);
            return View(contato);
        }
        public IActionResult ApagarConfirmacao(int id)
        {
            ContatoModel contato = _contatoRepositorio.ListarPorId(id);
            return View(contato);
        }
        public IActionResult Apagar(int id)
        {
            try
            {
              bool apagado =  _contatoRepositorio.Apagar(id);
                if (apagado)
                {
                    TempData["MensagemSucesso"] = "Contato apagado com sucesso";
                }
                else
                {
                    TempData["MensagemErro"] = "Ops! não conseguimos apagar seu contato!";
                }
                return RedirectToAction("index");
            }
            catch(System. Exception erro)
            {
                TempData["MensagemErro"] = $"Ops! não conseguimos apagar o usuario, tente novamente,detalhe do erro: {erro.Message}";
                return RedirectToAction("index");
            }
        }
        [HttpPost]
        public IActionResult Criar(ContatoModel contato)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _contatoRepositorio.Adicionar(contato);
                    TempData["MensagemSucesso"] = "Contato cadastrado com sucesso";
                    return RedirectToAction("Index");
                }
                return View(contato);

            }
            catch ( System. Exception erro )
            {
                TempData["MensagemErro"] = $"Ops! não conseguimos cadastrar seu contato,tente novamente,detalhe do erro:{erro.Message}";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Alterar(ContatoModel contato)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _contatoRepositorio.Atualizar(contato);
                    TempData["MensagemSucesso"] = "Contato Alterado com sucesso";
                    return RedirectToAction("Index");
                }
                return View("Editar", contato);
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Ops! não conseguimos Atualizar seu contato,tente novamente,detalhe do erro:{erro.Message}";
                return RedirectToAction("Index");
            }
        }
    }
}
