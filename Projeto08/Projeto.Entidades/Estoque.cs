using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Entidades
{
    public class Estoque
    {
        private int idEstoque;
        private string nome;
        private string descricao;
        private List<Produto> produtos;

        public Estoque()
        {

        }
        public Estoque(int idEstoque, string nome, string descricao, List<Produto> produtos)
        {
            IdEstoque = idEstoque;
            Nome = nome;
            Descricao = descricao;
            Produtos = produtos;
        }

        public int IdEstoque
        {
            set { idEstoque = value; }
            get { return idEstoque;  }
        }
        public string Nome
        {
            set { nome = value; }
            get { return nome;  }
        }
        public string Descricao
        {
            set { descricao = value; }
            get { return descricao; }
        }
        public List<Produto> Produtos
        {
            set { produtos = value; }
            get { return produtos;  }
        }

        public override string ToString()
        {
            return "Id Estoque: " + idEstoque + "Nome: " + nome
                + "Descrição: " + descricao;
        }
    }
}
