using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using VendasWebMvc.Models;

namespace VendasWebMvc.Controllers
{
    public class DepartamentosController : Controller
    {
        public IActionResult Index()
        {
            List<Departamentos> lista = new List<Departamentos>();

            lista.Add(new Departamentos { Id = 1, Nome = "Eletronico" });
            lista.Add(new Departamentos { Id = 2, Nome = "Vendas" });
            lista.Add(new Departamentos { Id = 3, Nome = "Manutenção" });
            lista.Add(new Departamentos { Id = 4, Nome = "Gerencia" });

            return View(lista);

        }
    }
}
