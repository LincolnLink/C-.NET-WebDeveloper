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
    public partial class ExclusaoProduto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    //resgatar o id enviado pela URL (QueryString)
                    int id = int.Parse(Request.QueryString["id"]);

                    ProdutoBusiness rep = new ProdutoBusiness();                   

                    Produto p = rep.EncontrarProduto(id);

                    lblIdProduto.Text = p.IdProduto.ToString();
                    lblNome.Text = p.Nome;
                    lblPreco.Text = p.Preco.ToString();
                    lblQuantidade.Text = p.Quantidade.ToString();
                    lblDataCadastro.Text = p.DataCadastro.ToString();
                    lblEstoque.Text = p.Estoque.IdEstoque.ToString();
                }
                catch (Exception ex)
                {
                    lblMensagem.Text = ex.Message;
                }
            }
        }

        protected void BtnExcluir_Click(object sender, EventArgs e)
        {

           
            try
            {
                int id2 = int.Parse(lblIdProduto.Text);
                ProdutoBusiness rep = new ProdutoBusiness();
                rep.Excluir(id2);

                BtnExcluir.Enabled = false;
              
                lblMensagem.Text = "Produto excluido com sucesso!!";
                /*lblMensagem.CssClass = "label label-success";*/
            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }
        }
    }
}