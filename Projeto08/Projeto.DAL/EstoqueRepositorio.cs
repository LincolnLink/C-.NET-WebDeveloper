using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Projeto.Entidades;


namespace Projeto.DAL
{
    public class EstoqueRepositorio : Conexao
    {
        public void Insert(Estoque e)
        {
            OpenConnection();
            string query = "insert into Estoque(NomeEstoque, Descricao)"
                        + "values(@NomeEstoque, @Descricao)";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@NomeEstoque", e.Nome);
            cmd.Parameters.AddWithValue("@Descricao", e.Descricao);
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
        public void Update(Estoque e)
        {
            OpenConnection();
            string query = "update Estoque set NomeEstoque = @NomeEstoque, Descricao = @Descricao where IdEstoque = @IdEstoque";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@IdEstoque", e.IdEstoque);
            cmd.Parameters.AddWithValue("@NomeEstoque", e.Nome);
            cmd.Parameters.AddWithValue("@Descricao", e.Descricao);
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
        public void Delete(int idEstoque)
        {
            OpenConnection();
            string query = "delete from Estoque where idEstoque = @idEstoque";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@idEstoque", idEstoque);
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
        public List<Estoque> FindAll()
        {
            OpenConnection();
            string query = "select * from Estoque";

            cmd = new SqlCommand(query, con);
            dr = cmd.ExecuteReader();

            List<Estoque> lista = new List<Estoque>();

            while (dr.Read())
            {
                Estoque e = new Estoque();
                e.IdEstoque = Convert.ToInt32(dr["idEstoque"]);
                e.Nome = Convert.ToString(dr["NomeEstoque"]);
                e.Descricao = Convert.ToString(dr["Descricao"]);
                lista.Add(e);
            }
            CloseConnection();
            return lista;
        }
        public Estoque FindById(int idEstoque)
        {
            OpenConnection();
            string query = "select * from Estoque where idEstoque = @idEstoque";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@idEstoque", idEstoque);
            dr = cmd.ExecuteReader();

            Estoque e = null;

            if (dr.Read())
            {
                e = new Estoque();
                e.IdEstoque = Convert.ToInt32(dr["idEstoque"]);
                e.Nome = Convert.ToString(dr["NomeEstoque"]);
                e.Descricao = Convert.ToString(dr["Descricao"]);
            }

            CloseConnection();
            return e;

        }
    }
}
