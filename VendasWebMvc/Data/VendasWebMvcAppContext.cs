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

        public DbSet<Departamentos> Departamento { get; set; }
        public DbSet<Vendedor> Vendedor { get; set; }
        public DbSet<RegistroDeVenda> RegistroDeVenda { get; set; }

    }
}
