using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgendaContatos.Models;
using Microsoft.AspNetCore.Mvc;

namespace AgendaContatos.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.ListaClientes = new ClienteModel().ListarTodosClientes();
            return View();
        }

        [HttpGet]
        public IActionResult Cadastro()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(ClienteModel cliente)
        {
            if(ModelState.IsValid)
            {
                cliente.Inserir();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}