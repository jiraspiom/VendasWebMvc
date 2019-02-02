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

        public IActionResult Deletar( int? id) //o "?" significa que é opcional
        {
            //set o id esta preenchido
            if (id == null)
            {
                return NotFound();
            }

            var objeto = _vendedorServico.EncontrarPorID(id.Value);

            //se foi encontrando o objeto
            if (objeto == null)
            {
                return NotFound();
            }

            return View(objeto);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Deletar(int id)
        {
            _vendedorServico.Remover(id);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Detalhar(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var objeto = _vendedorServico.EncontrarPorID(id.Value);
            if (objeto == null)
            {
                return NotFound();
            }

            return View(objeto);

        }


    }
}
