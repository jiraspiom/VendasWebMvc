using System;
using VendasWebMvc.Models.ViewModelo;

namespace VendasWebMvc.Models
{
    public class RegistroDeVenda
    {

        public int Id { get; set; }
        public DateTime Data { get; set; }
        public double Valor { get; set; }
        public StatusVenda Status { get; set; }

        //associação outra classe
        public Vendedor vendedor { get; set; }


        public RegistroDeVenda()
        {
        }

        public RegistroDeVenda(int id, DateTime data, int valor, StatusVenda status, Vendedor vendedor)
        {
            Id = id;
            Data = data;
            this.Valor = valor;
            this.Status = status;
            this.vendedor = vendedor;
        }
    }
}
