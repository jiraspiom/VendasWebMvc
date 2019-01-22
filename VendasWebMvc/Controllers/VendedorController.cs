using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VendasWebMvc.Models;
using VendasWebMvc.Models.ViewModelo;
using VendasWebMvc.Servicos;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VendasWebMvc.Controllers
{
    public class VendedorController : Controller
    {
        private readonly VendedorServico _vendedorServico;
        private readonly DepartamentoServico _departamentoServico;

        public VendedorController(VendedorServico vendedorServico, DepartamentoServico departamentoServico)
        {
            _vendedorServico = vendedorServico;
            _departamentoServico = departamentoServico;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var list = _vendedorServico.FindAll();

            return View(list);

        }

        public IActionResult Criar()
        {
            var departamentos = _departamentoServico.FindAll();
            var viewModel = new VendedorViewModel { Departamento = departamentos};

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Criar(Vendedor vendedor)
        {
            _vendedorServico.Inserir(vendedor);
           // return RedirectToAction("Index");
            return RedirectToAction(nameof(Index));
        }


    }
}
