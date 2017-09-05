using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Entidades;
using System.Data.SqlClient;

namespace Projeto.DAL
{
    public class ProdutoRepositorio : Conexao
    {
        #region Inserir

        public void Insert(Produto p)
        {
            OpenConnection();

            string query = "insert into Produto( Nome, Preco, Quantidade, DataCadastro, IdEstoque)" +
                "values( @nome, @preco, @quantidade, GetDate(), @idEstoque)";

            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@idProduto", p.IdProduto);
            cmd.Parameters.AddWithValue("@nome", p.Nome);
            cmd.Parameters.AddWithValue("@preco", p.Preco);
            cmd.Parameters.AddWithValue("@quantidade", p.Quantidade);            
            cmd.Parameters.AddWithValue("@idEstoque", p.Estoque.IdEstoque);
            cmd.ExecuteNonQuery();
            CloseConnection();
        }

        #endregion

        #region Atualizar

        public void Update(Produto p)
        {
            OpenConnection();
            string query = "update Produto set Nome = @nome, Preco = @preco, Quantidade = @quantidade,"
                + " IdEstoque = @idEstoque where idProduto = @idProduto";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@IdProduto", p.IdProduto);
            cmd.Parameters.AddWithValue("@nome", p.Nome);
            cmd.Parameters.AddWithValue("@preco", p.Preco);
            cmd.Parameters.AddWithValue("@quantidade", p.Quantidade);
            cmd.Parameters.AddWithValue("@idEstoque", p.Estoque.IdEstoque);
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
        #endregion

        #region Deletar

        public void Delete(int idProduto)
        {
            OpenConnection();
            string query = "delete from Produto where idProduto = @idProduto";

            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@idProduto", idProduto);
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
        #endregion

        #region SelecionarTotodos

        public List<Produto> FindAll()
        {
            OpenConnection();         

            string query = "select p.IdProduto, p.Nome, p.Preco, p.Quantidade," +
                " p.DataCadastro, e.IdEstoque, e.NomeEstoque as NomeEstoque," +
                " e.Descricao from Produto p inner join Estoque e " +
                "on e.IdEstoque = p.IdEstoque";
            cmd = new SqlCommand(query, con);
            dr = cmd.ExecuteReader();
            List<Produto> lista = new List<Produto>();

            while (dr.Read())
            {
                Produto p = new Produto();
                p.Estoque = new Estoque();

                p.IdProduto = Convert.ToInt32(dr["IdProduto"]);
                p.Nome = Convert.ToString(dr["Nome"]);
                p.Preco = Convert.ToDecimal(dr["Preco"]);
                p.Quantidade = Convert.ToInt32(dr["Quantidade"]);
                p.DataCadastro = Convert.ToDateTime(dr["DataCadastro"]);
                p.Estoque.IdEstoque = Convert.ToInt32(dr["IdEstoque"]);
                p.Estoque.Nome = Convert.ToString(dr["NomeEstoque"]);
                p.Estoque.Descricao = Convert.ToString(dr["Descricao"]);
                lista.Add(p);
            }
            CloseConnection();
            return lista;
        }
        #endregion

        
        #region SelecionarTotodosPeloIdEstoque
        public List<Produto> FindAll(int idEstoque)
        {
            OpenConnection();
            string query = "select p.IdProduto, p.Nome, p.Preco, p.Quantidade, " +
                " p.DataCadastro, e.IdEstoque, e.NomeEstoque as NomeEstoque, " +
                " e.Descricao from Produto p inner join Estoque e " +
                "on e.IdEstoque = p.IdEstoque " +
                "where p.IdEstoque = @IdEstoque ";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@IdEstoque", idEstoque);
            dr = cmd.ExecuteReader();
            List<Produto> lista = new List<Produto>();
            while (dr.Read())
            {
                Produto p = new Produto();
                p.Estoque = new Estoque();
                p.IdProduto = Convert.ToInt32(dr["IdProduto"]);
                p.Nome = Convert.ToString(dr["Nome"]);
                p.Preco = Convert.ToDecimal(dr["Preco"]);
                p.Quantidade = Convert.ToInt32(dr["Quantidade"]);
                p.DataCadastro = Convert.ToDateTime(dr["DataCadastro"]);
                p.Estoque.IdEstoque = Convert.ToInt32(dr["IdEstoque"]);
                p.Estoque.Nome = Convert.ToString(dr["NomeEstoque"]);
                p.Estoque.Descricao = Convert.ToString(dr["Descricao"]);
                lista.Add(p);
            }
            CloseConnection();
            return lista;
        }
        #endregion
    

        #region buscarPorUmProduto
        public Produto FindById(int idProduto)
        {

            OpenConnection();
            string query = "select * from Produto where idProduto = @idProduto";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@idProduto", idProduto);
            dr = cmd.ExecuteReader();
            Produto p = null;

            if (dr.Read())
            {
                p = new Produto();
                p.Estoque = new Estoque();

                p.IdProduto = Convert.ToInt32(dr["IdProduto"]);
                p.Nome = Convert.ToString(dr["Nome"]);
                p.Preco = Convert.ToDecimal(dr["Preco"]);
                p.Quantidade = Convert.ToInt32(dr["Quantidade"]);
                p.DataCadastro = Convert.ToDateTime(dr["DataCadastro"]);
                p.Estoque.IdEstoque = Convert.ToInt32(dr["IdEstoque"]);
            }

            CloseConnection();
            return p;

        }
        #endregion
    }
}
