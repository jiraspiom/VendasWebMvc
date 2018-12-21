using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using VendasWebMvc.Models;

namespace VendasWebMvc.Data
{
    public class VendasWebMvcAppContext : DbContext
    {

        public VendasWebMvcAppContext(DbContextOptions<VendasWebMvcAppContext> options) : base(options)
        {

        }

        public DbSet<Departamento> Departamento { get; set; }
        public DbSet<Vendedor> Vendedor { get; set; }
        public DbSet<RegistroDeVenda> RegistroDeVenda { get; set; }

        public static implicit operator VendasWebMvcAppContext(PopularBase v)
        {
            throw new NotImplementedException();
        }
    }
}
