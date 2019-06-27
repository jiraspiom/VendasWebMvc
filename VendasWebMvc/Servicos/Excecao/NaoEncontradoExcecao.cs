using System;
namespace VendasWebMvc.Servicos.Excecao
{
    public class NaoEncontradoExcecao : ApplicationException
    {
        public NaoEncontradoExcecao(string mensagem) : base(mensagem) 
        {

        }

    }
}
