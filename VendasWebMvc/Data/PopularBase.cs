using System;
using System.Linq;
using VendasWebMvc.Models;
using VendasWebMvc.Models.ViewModelo;

namespace VendasWebMvc.Data
{
    public class PopularBase
    {

        private VendasWebMvcAppContext _contexto;

        public PopularBase(VendasWebMvcAppContext contexto)
        {
            _contexto = contexto;
        }

        public void Popular()
        {

            if (_contexto.Departamento.Any() || _contexto.RegistroDeVenda.Any() || _contexto.Vendedor.Any())
            {
                return; //BD ja foi populado
            }

            Departamento d1 = new Departamento(1, "Computador");
            Departamento d2 = new Departamento(2, "Eletronicos");
            Departamento d3 = new Departamento(3, "Vestuario");
            Departamento d4 = new Departamento(4, "Livros");

            Vendedor v1 = new Vendedor(1, "AAAAAA", new DateTime(1990, 1, 1), 1200.00, d1);
            Vendedor v2 = new Vendedor(2, "BBBBB", new DateTime(1990, 2, 2), 2200, d2);


            RegistroDeVenda r1 = new RegistroDeVenda(1, new DateTime(2018, 12, 1), 100, StatusVenda.vendido, v1);
            RegistroDeVenda r2 = new RegistroDeVenda(2, new DateTime(2018, 12, 2), 200, StatusVenda.vendido, v2);


            _contexto.AddRange(d1, d2, d3, d4);
            _contexto.AddRange(v1, v2);
            _contexto.AddRange(r1, r2);



            _contexto.SaveChanges();

        }
    }
}
