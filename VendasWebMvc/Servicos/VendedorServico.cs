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
            //obj.Departamento = _contexto.Departamento.First();
            _contexto.Add(obj);
            _contexto.SaveChanges();
        }

        public Vendedor EncontrarPorID(int id)
        {
            return _contexto.Vendedor.FirstOrDefault(objeto => objeto.Id == id);
        }

        public void Remover(int id)
        {
            ///encontrar o objeto
            var objeto = _contexto.Vendedor.Find(id);
            //deletar o objeto do dbset 
            _contexto.Vendedor.Remove(objeto);
            //salva a operacao realizada
            _contexto.SaveChanges();
        }


    }
}
