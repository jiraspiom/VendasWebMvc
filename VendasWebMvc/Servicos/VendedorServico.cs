using System;
using System.Collections.Generic;
using System.Linq;
using VendasWebMvc.Data;
using VendasWebMvc.Models;

namespace VendasWebMvc.Servicos
{
    public class VendedorServico
    {

        public readonly VendasWebMvcAppContext _contexto;


        public VendedorServico(VendasWebMvcAppContext contexto)
        {
            _contexto = contexto;
        }


        public List<Vendedor> FindAll()
        {
            return _contexto.Vendedor.ToList();
        }

        public void Inserir(Vendedor obj)
        {
            //adicionado provisioriamento para nao gerar aleta ao adicionar vendedor sem departamento.
            obj.Departamento = _contexto.Departamento.First();
            _contexto.Add(obj);
            _contexto.SaveChanges();
        }

    }
}
