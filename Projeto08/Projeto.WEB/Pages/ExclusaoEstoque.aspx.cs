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
        //Evento executado sempre que a página é carregada..
        protected void Page_Load(object sender, EventArgs e)
        {
            //verificar se a página esta sendo carregada pela 1º vez..
            if (!IsPostBack) //se a página não foi aberta?
            {
                try
                {
                    //resgatar o id enviado pela URL (QueryString)
                    int idEstoque = int.Parse(Request.QueryString["id"]);

                    //acessar a camada de negócio..
                    EstoqueBusiness business = new EstoqueBusiness();
                    Estoque estoque = business.BuscasPorId(idEstoque);

                    //imprimir os dados na página..
                    lblCodigo.Text = estoque.IdEstoque.ToString();
                    lblNome.Text = estoque.Nome;
                    lblDescricao.Text = estoque.Descricao;
                }
                catch (Exception ex)
                {
                    //exibir mensagem de erro..
                    lblMensagem.Text = ex.Message;
                }
            }
        }

        //evento de exclusão..
        protected void btnExclusao_Click(object sender, EventArgs e)
        {
            try
            {
                //resgatar o id do estoque..
                int idEstoque = int.Parse(lblCodigo.Text);

                //excluir o estoque..
                EstoqueBusiness business = new EstoqueBusiness();
                business.Excluir(idEstoque);

                lblMensagem.Text = "Estoque excluido com sucesso.";

                //desativar o botão..
                btnExclusao.Enabled = false;
            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }
        }
    }
}