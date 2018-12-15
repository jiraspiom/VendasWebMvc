using System;
using VendasWebMvc.Models.ViewModelo;

namespace VendasWebMvc.Models
{
    public class RegistroDeVenda
    {

        public int Id { get; set; }
        public DateTime Data { get; set; }
        public int Quantidade { get; set; }
        public StatusVenda Status { get; set; }

        //assossiacao
        public Vendedor vendedor { get; set; }


        public RegistroDeVenda()
        {
        }

        public RegistroDeVenda(int id, DateTime data, int quantidade, StatusVenda status)
        {
            Id = id;
            Data = data;
            this.Quantidade = quantidade;
            this.Status = status;
        }

    }
}
