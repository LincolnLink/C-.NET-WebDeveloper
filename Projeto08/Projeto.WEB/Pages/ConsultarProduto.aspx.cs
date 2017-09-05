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
            if ( ! IsPostBack)
            {
                CarregarProdutos();
                CarregarEstoques();
            }
        }

        private void CarregarEstoques()
        {
            try
            {
                EstoqueBusiness rep = new EstoqueBusiness();
                List<Estoque> lista = new List<Estoque>();

                lista = rep.ListarTodos();

                ddlEstoque.DataSource = lista;
                ddlEstoque.DataValueField = "IdEstoque";
                ddlEstoque.DataTextField = "Nome";
                ddlEstoque.DataBind();

                ddlEstoque.Items.Insert(0, new ListItem ("- Selecione uma Opção -", ""));


            }
            catch (Exception ex)
            {
                lblmensagem.Text = ex.Message;
            }
        }

        private void CarregarProdutos()
        {
            try
            {
                ProdutoBusiness rep = new ProdutoBusiness();
                List<Produto> lista = new List<Produto>();

                lista = rep.ListarTodos();
                lblmensagem.Text = "Foram encontrados: " + lista.Count() + " Produtos";

                gridProdutos.DataSource = lista;
                gridProdutos.DataBind();
            }
            catch (Exception ex)
            {
                lblmensagem.Text = ex.Message;
            }
        }
        
        //evento executado no campo dropdownlist
        protected void ddlEstoque_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //verificar se o campo dropdownlist não esta vazio..
                if ( ! string.IsNullOrEmpty(ddlEstoque.SelectedValue))
                {
                    //resgatar o id do estoque selecionado..
                    int idEstoque = int.Parse(ddlEstoque.SelectedValue);

                    ProdutoBusiness business = new ProdutoBusiness();
                    List<Produto> lista = business.ConsultarTodos(idEstoque);

                    lblmensagem.Text = "Quantidade de produtos neste estoque: "+ lista.Count;

                    gridProdutos.DataSource = lista;
                    gridProdutos.DataBind();
                }
                else
                {
                    CarregarProdutos();
                }
            }
            catch (Exception ex)
            {                
                lblmensagem.Text = ex.Message;
            }
        }

    }
}