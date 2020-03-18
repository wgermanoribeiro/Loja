﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Loja.Models;
using Microsoft.AspNetCore.Mvc;

namespace Loja.Controllers
{
    public class ProdutoController : Controller
    {
        [HttpGet]
        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(ProdutoViewModel produto)
        {
            if (!ModelState.IsValid)
            {
                return View(produto);
            }
            return View();
        }
    }


}