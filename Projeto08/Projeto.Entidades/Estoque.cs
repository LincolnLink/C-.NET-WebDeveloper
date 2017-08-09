using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Entidades
{
    public class Estoque
    {
        #region Atributo
        private int idEstoque;
        private string nome;
        private string descricao;
        private List<Produto> produtos;
        #endregion

        #region Contrutores
        public Estoque()
        {

        }
        public Estoque(int idEstoque, string Nome, string descricao)
        {
            IdEstoque = idEstoque;
            Nome = nome;
            Descricao = descricao;
        }

        #endregion

        #region Propriedade
        public int IdEstoque
        {
            set { idEstoque = value; }
            get { return idEstoque; }
        }
        public string Nome
        {
            set { nome = value; }
            get { return nome; }
        }
        public string Descricao
        {
            set { descricao = value; }
            get { return descricao; }
        }
        public List<Produto> Produtos
        {
            set { produtos = value; }
            get { return produtos; }
        }
        #endregion
    }
}
