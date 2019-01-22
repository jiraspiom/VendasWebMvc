using System;
using System.Collections.Generic;
using System.Linq;
using VendasWebMvc.Data;
using VendasWebMvc.Models;

namespace VendasWebMvc.Servicos
{
    public class DepartamentoServico
    {
        VendasWebMvcAppContext _contexto = new VendasWebMvcAppContext();

        public DepartamentoServico(VendasWebMvcAppContext contexto)
        {
            _contexto = contexto;
        }

        public List<Departamento> FindAll()
        {
            return _contexto.Departamento.OrderBy(x => x.Nome).ToList();
        }

    }
}
