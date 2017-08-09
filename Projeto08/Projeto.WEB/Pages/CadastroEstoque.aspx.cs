using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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

        protected void btnCadastro_Click(object sender, EventArgs e)
        {
            if(ValidateFiels())
            {
                //imprimir mensagem
                lblMensagem.Text = "Estoquecadastrado com sucesso";

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