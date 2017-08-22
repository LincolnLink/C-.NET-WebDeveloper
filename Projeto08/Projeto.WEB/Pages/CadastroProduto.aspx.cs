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
    public partial class CadastroProduto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ( ! IsPostBack)
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

                    //incluindo um item default no campo..
                    ddlEstoque.Items.Insert(0, new ListItem("- Escolha uma Opção -", ""));
                }
                catch(Exception ex)
                {
                    lblMessagem.Text = ex.Message;
                    lblMessagem.CssClass = "label label-danger";
                }
            }
        }

        protected void BtnCadastrar_Click(object sender, EventArgs e)
        {

            lblMessagem.Text = string.Empty;
            lblErroNome.Text = string.Empty;
            lblErroPreco.Text = string.Empty;
            lblErroQuantidade.Text = string.Empty;

            lblErroEstoque.Text = string.Empty;
            try
            {
                if (VerificaCampos())
                {


                    //alimentar o objeto
                    Produto p = new Produto();
                    p.Estoque = new Estoque();

                    p.Nome = txtNome.Text;
                    p.Preco = decimal.Parse(txtPreco.Text);
                    p.Quantidade = int.Parse(txtQuantidade.Text);
                    p.Estoque.IdEstoque = int.Parse(ddlEstoque.SelectedValue);

                    //instanciar o objeto que cadastra
                    ProdutoBusiness rep = new ProdutoBusiness();
                    rep.Cadastrar(p);

                    //mensagem falando que foi cadastrado
                    lblMessagem.Text = "Produto cadastrado com sucesso!";
                    lblMessagem.CssClass = "label label-success";

                    //limpa os campos
                    txtNome.Text = string.Empty;
                    txtPreco.Text = string.Empty;
                    txtQuantidade.Text = string.Empty;

                }
                else
                {
                    lblMessagem.Text = "Preencha todos os campos!";
                    lblMessagem.CssClass = "label label-danger";
                }
            }
            catch(Exception ex)
            {
                lblMessagem.Text = ex.Message;
            }
        }

        public bool VerificaCampos()
        {
            bool resultado = true;

            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                lblErroNome.Text = "Insira um Nome!";
                resultado = false;
            }
            if (string.IsNullOrWhiteSpace(txtPreco.Text))
            {
                lblErroNome.Text = "Insira um Preço!";
                resultado = false;
            }
            if (string.IsNullOrWhiteSpace(txtQuantidade.Text))
            {
                lblErroNome.Text = "Insira a quantidade!";
                resultado = false;
            }
            return resultado;

        }
    }
}