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
    public partial class ConsultarProduto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    ProdutoBusiness rep = new ProdutoBusiness();
                    List<Produto> lista = new List<Produto>();

                    lista = rep.ListarTodos();
                    lblmensagem.Text = "Foram encontrados: " + lista.Count() + " Produtos";

                    gridProduto.DataSource = lista;
                    gridProduto.DataBind();
                   
                }
                catch(Exception ex)
                {
                    lblmensagem.Text = ex.Message;
                }
            }
        }
    }
}