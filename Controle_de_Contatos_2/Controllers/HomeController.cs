﻿using Controle_de_Contatos_2.Filters;
using Controle_de_Contatos_2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Controle_de_Contatos_2.Controllers
{
    [PaginaParaUsuarioLogado]
    public class HomeController : Controller
    {
       

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}