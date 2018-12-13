using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VendasWebMvc.Data
{
    public class VendasWebMvcAppContext : DbContext
    {

        public VendasWebMvcAppContext(DbContextOptions<VendasWebMvcAppContext> options) : base(options)
        {

        }

        public DbSet<VendasWebMvc.Models.Departamentos> Departamento { get; set; }

    }
}
