using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Entidades;
using Projeto.DAL;
using Projeto.BLL.Excecoes.Estoques;

namespace Projeto.BLL
{
    public class EstoqueBusiness
    {
        public void Cadastrar(Estoque e)
        {
            EstoqueRepositorio rep = new EstoqueRepositorio();
            rep.Insert(e);
        }

        public void Atualizar(Estoque e)
        {
            EstoqueRepositorio rep = new EstoqueRepositorio();

            if (rep.FindById(e.IdEstoque) != null)
            {
                rep.Update(e);
            }
            else
            {
                throw new EstoqueNaoEncontradoException();
            }
        }

        public void Excluir(int idEstoque)
        {
            EstoqueRepositorio rep = new EstoqueRepositorio();

            if (rep.FindById(idEstoque) != null)
            {             
                if (!rep.HastProduto(idEstoque))
                {
                    rep.Delete(idEstoque);
                }
                else
                {
                    throw new EstoqueTemUmProdutoException();
                }
            }
            else
            {
                throw new EstoqueNaoEncontradoException();
            }
        }

        public List<Estoque> ListarTodos()
        {

            EstoqueRepositorio rep = new EstoqueRepositorio();
            return rep.FindAll();
        }

        public Estoque BuscasPorId(int idEstoque)
        {
            EstoqueRepositorio rep = new EstoqueRepositorio();
            Estoque e = rep.FindById(idEstoque);

            if (e != null)
            {
                return e;
            }
            else
            {
                throw new EstoqueNaoEncontradoException();
            }
        }
    }
}
