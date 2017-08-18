using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Projeto.Entidades;
using Projeto.BLL;

namespace Projeto.WEB.Pages
{
    public partial class ConsultarEstoque : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                EstoqueBusiness business = new EstoqueBusiness();
                List<Estoque> lista = new List<Estoque>();

                lista = business.ListarTodos();
                lblMensagem.Text = "Quantidades de Estoque encontrados: " + lista.Count();

                gridEstoque.DataSource = lista;
                gridEstoque.DataBind();
                    
            }
            catch(Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }

        }
    }
}