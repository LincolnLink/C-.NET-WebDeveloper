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
    public partial class EdicaoProduto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ( ! IsPostBack)
            {
                try
                {
                    //pegando id da URL
                    int id = int.Parse(Request.QueryString["id"]);

                    //instanciando objetos
                    ProdutoBusiness rep = new ProdutoBusiness();
                    EstoqueBusiness repEst = new EstoqueBusiness();
                    Produto p = new Produto();
                    Estoque est = new Estoque();

                    //pegando valores dos campos
                    p = rep.EncontrarProduto(id);
                    List<Estoque> lista = repEst.ListarTodos();

                    //alimentando os campos
                    txtId.Text = p.IdProduto.ToString();
                    txtNome.Text = p.Nome;
                    txtPreco.Text = p.Preco.ToString();
                    txtQuantidade.Text = p.Quantidade.ToString();
                    txtDataCadastrada.Text = p.DataCadastro.ToString();

                    //alimentar o dropdown do estoque
                    ddlEstoque.Text = p.Estoque.IdEstoque.ToString();
                    ddlEstoque.DataSource = lista;
                    ddlEstoque.DataValueField = "IdEstoque";
                    ddlEstoque.DataTextField = "Nome";
                    ddlEstoque.DataBind();

                    //incluindo um item default no campo..
                    ddlEstoque.Items.Insert( 0, new ListItem(p.Estoque.IdEstoque.ToString(), ddlEstoque.Text));

                }
                catch (Exception ex)
                {
                    lblMessagem.Text = ex.Message;
                }
            }
        }

        protected void BtnEditar_Click(object sender, EventArgs e)
        {
            //confirmar se os campso estão em branco
            if (ValidarCampos())
            {
                //Try Catch
                try
                {
                    //Pegar o valor do ID
                    int idProduto = int.Parse(txtId.Text);
                    
                    //instanciar os objetos para a edição
                    ProdutoBusiness rep = new ProdutoBusiness();
                    Produto p = new Produto();
                    p.Estoque = new Estoque();

                    //alimentar o objeto!
                    p.IdProduto = int.Parse(txtId.Text);
                    p.Nome = txtNome.Text;
                    p.Preco = decimal.Parse(txtPreco.Text);
                    p.Quantidade = int.Parse(txtQuantidade.Text);
                    p.Estoque.IdEstoque = int.Parse(ddlEstoque.Text);
                  
                    //Editar!
                    rep.Atualizar(p);

                    //limpar os campos de erro
                    lblErroNome.Text = string.Empty;
                    lblErroPreco.Text = string.Empty;
                    lblErroQuantidade.Text = string.Empty;

                    //desativar o botão
                    BtnEditar.Enabled = false;

                    //mensagem que foi editado com sucesso! e alterar css
                    lblMessagem.Text = "Produto: " + p.Nome + " alterado com sucesso!";
                    lblMessagem.CssClass = " success alert-success";
                }
                catch (Exception ex)
                {
                    lblMessagem.Text = ex.Message;
                }
            }
        }

        public bool ValidarCampos()
        {
            bool resultado = true;
            //confirmar cada campo se esta vazio ou não.
            return resultado;
        }
    }
}