﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace VendasWebMvc.Models
{
    public class Departamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        //associação com outra class
        public ICollection<Vendedor> Vendedores { get; set; } = new List<Vendedor>();

        public Departamento()
        {
        }

        public Departamento(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public void AdicionarVendedor(Vendedor vendedor)
        {
            Vendedores.Add(vendedor);
        }

        //total de vendas do departamento
        public double TotalVendas(DateTime inicial, DateTime final)
        {
            return Vendedores.Sum(vend => vend.TotalVenda(inicial, final));
        }

    }

}
