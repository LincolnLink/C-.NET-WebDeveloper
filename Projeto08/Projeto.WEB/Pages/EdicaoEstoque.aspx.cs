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
    public partial class EdicaoEstoque : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Verificar se a pagina esta sendo carregada pela primeira vez.
            if (!IsPostBack)
            {
                try
                {
                    //Pegar id da URL.
                    int idEstoque = int.Parse(Request.QueryString["id"]);

                    //Buscar o objeto pelo id que foi pego.
                    EstoqueBusiness rep = new EstoqueBusiness();
                    Estoque estoque = rep.BuscasPorId(idEstoque);

                    //Alimentar os campos, com o objeto que foi retornado.
                    txtCodigo.Text = estoque.IdEstoque.ToString();
                    txtNome.Text = estoque.Nome.ToString();
                    txtDescricao.Text = estoque.Descricao.ToString();
                }
                catch (Exception ex)
                {
                    lblMensagem.Text = ex.Message;
                }            
            }
        }
        protected void btnEdicao_Click(object sender, EventArgs e)
        {
            //verificar se os campos estão preenchidos
            if (ValidateFields())
            {
                //Limpar a mensagem
                lblMensagem.Text = string.Empty;
                lblErroNome.Text = string.Empty;
                lblErroDescricao.Text = string.Empty;

                //passar os dados para ser editado
                Estoque estoque = new Estoque();
                estoque.IdEstoque = int.Parse(txtCodigo.Text);
                estoque.Nome = txtNome.Text;
                estoque.Descricao = txtDescricao.Text;

                //instanciar o objeto business
                EstoqueBusiness rep = new EstoqueBusiness();
                rep.Atualizar(estoque);

                //informar que já foi editado
                lblMensagem.Text = "Estoque editado com sucesso!";             

            }
        }

        private bool ValidateFields()
        {
            bool result = true;
            //informar que o campo não foi preenchido!
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                lblMensagem.Text = "Informe o Nome";
                result = false;
            }
            if (string.IsNullOrWhiteSpace(txtDescricao.Text))
            {
                lblMensagem.Text = "Informe a descrição";
                result = false;
            }
            return result;            
        }
    }
}