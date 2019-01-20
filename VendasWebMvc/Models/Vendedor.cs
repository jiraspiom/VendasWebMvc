using System;
using System.Collections.Generic;
using System.Linq;

namespace VendasWebMvc.Models
{
    public class Vendedor
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public double SalarioBase { get; set; }
        public int DepartamentoId { get; set; } //estou garantindo que esse id vai ter de existir

        //associação outra class
        public Departamento Departamento { get; set; }
        public ICollection<RegistroDeVenda> Vendas { get; set; }  = new List<RegistroDeVenda>();


        public Vendedor() 
        {
        }

        public Vendedor(int id, string nome, string email, DateTime dataNascimento, double salarioBase, Departamento departamento)
        {
            Id = id;
            Nome = nome;
            Email = email;
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
