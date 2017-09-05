using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.BLL.Excecoes.Estoques
{
    public class EstoqueTemUmProdutoException : Exception
    {
        public override string Message
        {
            get
            {
                return "Este Estoque tem produto, não pode ser excluido, " +
                    " precisa está vazio";
            }
        }
    }
}
