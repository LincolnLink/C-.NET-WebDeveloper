using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Projeto.Entidades
{
    public class Produto
    {
        private int idProduto;
        private string nome;
        private decimal preco;
        private int quantidade;
        private DateTime dataCadastro;
        private Estoque estoque;


        public Produto()
        {

        }
        public Produto(int idProduto, string nome, decimal preco, int quantidade, DateTime dataCadastro)
        {
            IdProduto = idProduto;
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
            DataCadastro = dataCadastro;
        }

        public int IdProduto
        {
            set { idProduto = value; }
            get { return idProduto; }
        }
        public string Nome
        {
            set { nome = value; }
            get { return nome; }
        }
        public decimal Preco
        {
            set { preco = value; }
            get { return preco; }
        }
        public int Quantidade
        {
            set { quantidade = value; }
            get { return Quantidade; }
        }
        public DateTime DataCadastro
        {
            set { dataCadastro = value; }
            get { return dataCadastro;  }
        }
        public Estoque Estoque
        {
            set { estoque = value; }
            get { return estoque;  }
        }

        public override string ToString()
        {
            return "Id: " + idProduto + "Nome: " + nome
                + "Preço: " + preco + "Quantidade: " + quantidade
                + "Data de Cadastro: " + dataCadastro;
        }
    }
}
