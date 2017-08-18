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
    public partial class ExclusaoEstoque : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //verifica se a pagina esta sendo aberta pela 1° vez
            if ( ! IsPostBack)
            {
                try
                {
                    //resgata o id enviado pela URL(QueryString)
                    int idEstoque = int.Parse(Request.QueryString["id"]);

                    //Acessar a camada de negócio...
                    EstoqueBusiness bussiness = new EstoqueBusiness();
                    Estoque estoque = bussiness.BuscasPorId(idEstoque);

                    //Alimenta a tela
                    lblCodigo.Text = estoque.IdEstoque.ToString();
                    lblNome.Text = estoque.Nome;
                    lblDescricao.Text = estoque.Descricao;
                    
                }
                catch (Exception ex)
                {
                    lblMensagem.Text = ex.Message;
                }
            }
        }

        protected void btnExclusao_Click(object sender, EventArgs e)
        {

            try
            {
                //resgatar o id do estoque
                int idEstoque = int.Parse(lblCodigo.Text);
                //excluir estoque
                EstoqueBusiness bussiness = new EstoqueBusiness();
                bussiness.Excluir(idEstoque);

                lblMensagem.Text = "Estoque excluido com sucesso";
                //desativar botão
                btnExclusao.Enabled = false;
            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }

        }
        
    }
}