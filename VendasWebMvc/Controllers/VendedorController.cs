using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VendasWebMvc.Servicos;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VendasWebMvc.Controllers
{
    public class VendedorController : Controller
    {
        private readonly VendedorServico _vendedorServico;

        public VendedorController(VendedorServico vendedorServico)
        {
            _vendedorServico = vendedorServico;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var list = _vendedorServico.FindAll();

            return View(list);

        }
    }
}
