using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Entidades;
using Projeto.DAL;
using Projeto.BLL.Excecoes.Produtos;

namespace Projeto.BLL
{
    public class ProdutoBusiness
    {
        #region Cadastrar

        public void Cadastrar(Produto p)
        {
            ProdutoRepositorio rep = new ProdutoRepositorio();
            rep.Insert(p);
        }
        #endregion

        #region Atualizar

        public void Atualizar(Produto p)
        {
            ProdutoRepositorio rep = new ProdutoRepositorio();

            if (rep.FindById(p.IdProduto) != null)
            {
                rep.Update(p);
            }
            else
            {
                throw new ProdutoNaoEncontradoException();
            }

        }
        #endregion

        #region Excluir

        public void excluir(int idProduto)
        {
            ProdutoRepositorio rep = new ProdutoRepositorio();

            if (rep.FindById(idProduto) != null)
            {
                rep.delete(idProduto);
            }
            else
            {
                throw new ProdutoNaoEncontradoException();
            }
        }
        #endregion

        #region ListarTodos
        public List<Produto> ListarTodos()
        {
            ProdutoRepositorio rep = new ProdutoRepositorio();
            return rep.FindAll();
        }
        #endregion

        #region ProcurarProduto

        public Produto EncontrarProduto(int idProduto)
        {
            ProdutoRepositorio rep = new ProdutoRepositorio();
            Produto e = rep.FindById(idProduto);

            if (e != null)
            {
                return e;
            }
            else
            {
                throw new ProdutoNaoEncontradoException();
            }
        }
        #endregion

    }
}
