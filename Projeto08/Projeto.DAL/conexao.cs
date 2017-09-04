using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Projeto.DAL
{
    public class Conexao
    {
        /// <summary>
        /// Atributos para a conexao
        /// </summary>
        protected SqlConnection con;
        protected SqlCommand cmd;
        protected SqlDataReader dr;
        protected SqlTransaction tr;

        protected void OpenConnection()
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\COTI informatica\GitHub\Aula08\Projeto08\Projeto.WEB\App_Data\Bank.mdf;Integrated Security=True");
            con.Open(); //conectando
        }
        protected void CloseConnection()
        {
            con.Close();
        }

    }
}
