﻿using ControledeContatos.Models;
using Microsoft.AspNetCore.Mvc;

namespace ControledeContatos.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Criar()
        {
            return View();
        }
        public IActionResult Editar()
        {
            return View();
        }
        public IActionResult Excluir()
        {
            return View();
        }
      //  [HttpPost]

        // public IActionResult Criar(ContatoModel contato)




    }
}

