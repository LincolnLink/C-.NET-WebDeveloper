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
    public partial class CadastroEstoque : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMensagem.Text = string.Empty;
            lblErroNome.Text = string.Empty;
            lblErroDescricao.Text = string.Empty;

        }

        protected void BtnCadastro_Click(object sender, EventArgs e)
        {
            if(ValidateFiels())
            { 
                try
                {
                    Estoque est = new Estoque(); 
                    est.Nome = txtNome.Text;
                    est.Descricao = txtDescricao.Text;

                    EstoqueBusiness rep = new EstoqueBusiness();
                    rep.Cadastrar(est);

                    lblMensagem.Text = "Estoquecadastrado com sucesso";

                    txtDescricao.Text = string.Empty;
                    txtNome.Text = string.Empty;

                }
                catch (Exception ex)
                {
                    lblMensagem.Text = ex.Message;
                } 
            }           
        }
        //metodo para validar formulario
        private bool ValidateFiels()
        {
            bool result = true;

            if(string.IsNullOrWhiteSpace(txtNome.Text))
            {
                lblErroNome.Text = "Por favor, informe o nome do Estoque!";
                result = false;
            }
            if(string.IsNullOrWhiteSpace(txtDescricao.Text))
            {
                lblErroDescricao.Text = "Por favor, a Descrição!";
                result = false;
            }
            return result;
        }
    }
}