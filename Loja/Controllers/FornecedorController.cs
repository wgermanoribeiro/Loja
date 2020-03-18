using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Loja.Models;
using Microsoft.AspNetCore.Mvc;

namespace Loja.Controllers
{
    public class FornecedorController : Controller
    {
        [HttpGet]
        public IActionResult CadastroFornecedor()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CadastroFornecedor(FornecedorViewModel fornecedor)
        {
            if (!ModelState.IsValid)
            {
                return View(fornecedor);
            }
            return View();
            
        }
    }
}