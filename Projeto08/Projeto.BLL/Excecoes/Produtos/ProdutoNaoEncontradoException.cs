using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.BLL.Excecoes.Produtos
{
    class ProdutoNaoEncontradoException :Exception
    {
        public override string Message
        {
            get
            {
                return "Produto não encontrado";
            }
        }
    }
}
