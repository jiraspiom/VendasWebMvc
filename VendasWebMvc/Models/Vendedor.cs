using System;
using System.Collections.Generic;
using System.Linq;

namespace VendasWebMvc.Models
{
    public class Vendedor
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public double SalarioBase { get; set; }

        //associação outra class
        public Departamento Departamento { get; set; }
        public ICollection<RegistroDeVenda> Vendas { get; set; } = new List<RegistroDeVenda>();


        public Vendedor() 
        {
        }

        public Vendedor(int id, string nome, DateTime dataNascimento, double salarioBase, Departamento departamento)
        {
            Id = id;
            Nome = nome;
            DataNascimento = dataNascimento;
            SalarioBase = salarioBase;
            this.Departamento = departamento;
        }

        public void AdicionarVenda(RegistroDeVenda rv)
        {
            Vendas.Add(rv);
        }

        public void DeletarVenda(RegistroDeVenda rv)
        {
            Vendas.Remove(rv);
        }

        public double TotalVenda(DateTime inicial, DateTime final)
        {
            //filtro por data, e pego a soma das vendas neste periodo
            return Vendas.Where(sr => sr.Data >= inicial && sr.Data <= final).Sum(sr => sr.Valor);
        }
    }
}
