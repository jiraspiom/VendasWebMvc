using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using VendasWebMvc.Data;
using VendasWebMvc.Models;
using VendasWebMvc.Servicos.Excecao;

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
            //assim nao trazia o departamento entao deve incluir o EntityFrameworkCore no name space para usar o Include
            //return _contexto.Vendedor.FirstOrDefault(objeto => objeto.Id == id);

            //fazendo inner join com tabela departamento
            return _contexto.Vendedor.Include(objeto => objeto.Departamento).FirstOrDefault(objeto => objeto.Id == id);
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


        public void Update(Vendedor obj)
        {
            if(!_contexto.Vendedor.Any(x => x.Id == obj.Id))
            {
                throw new NaoEncontradoExcecao("Id näo encontrado");
            }


            //para evitar um possivel erro de concorrencia
            try
            {
                _contexto.Update(obj);
                _contexto.SaveChanges();
            }
            //intercepto a execao a nivel de dado disparo uma execao a nivel de servico
            catch (DbUpdateConcurrencyException  ex)
            {
                //excecao a nivel de servico
                throw new DbCorrenteExcecao(ex.Message);

            }
        }

    }
}
