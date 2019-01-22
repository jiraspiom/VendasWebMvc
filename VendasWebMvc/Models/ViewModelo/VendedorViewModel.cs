using System;
using System.Collections.Generic;

namespace VendasWebMvc.Models.ViewModelo
{
    public class VendedorViewModel
    {
        public VendedorViewModel()
        {

        }
        public Vendedor Vendedor { get; set; }
        public ICollection<Departamento> Departamento { get; set; }

    }
}
