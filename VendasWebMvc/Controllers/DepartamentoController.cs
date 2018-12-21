using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using VendasWebMvc.Models;

namespace VendasWebMvc.Controllers
{
    public class DepartamentoController : Controller
    {
        public IActionResult Index()
        {
            List<Departamento> lista = new List<Departamento>();

            lista.Add(new Departamento { Id = 1, Nome = "Eletronico" });
            lista.Add(new Departamento { Id = 2, Nome = "Vendas" });
            lista.Add(new Departamento { Id = 3, Nome = "Manutenção" });
            lista.Add(new Departamento { Id = 4, Nome = "Gerencia" });

            return View(lista);

        }
    }
}
