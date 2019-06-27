using System;
namespace VendasWebMvc.Servicos.Excecao
{
    public class DbCorrenteExcecao : ApplicationException
    {
        public DbCorrenteExcecao(string mengaguem) :base(mengaguem)
        {
        }
    }
}
