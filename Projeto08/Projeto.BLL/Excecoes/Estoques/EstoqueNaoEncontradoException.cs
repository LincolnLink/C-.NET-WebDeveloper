using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.BLL.Excecoes.Estoques
{
    public class EstoqueNaoEncontradoException : Exception
    {
        public override string Message
        {
            get
            {
                return "Estoque não foi encontrado.";
            }
        }
    }
}
