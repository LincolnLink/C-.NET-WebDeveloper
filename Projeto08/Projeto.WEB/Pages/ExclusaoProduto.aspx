<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ExclusaoProduto.aspx.cs" Inherits="Projeto.WEB.Pages.ExclusaoProduto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Excluir Produto</title>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <link href="../Content/bootstrap-theme.min.css" rel="stylesheet" />
</head>
<body class="container">
    <h3>Excluir Produto</h3>
    <a href="/Pages/ConsultarProduto.aspx">Voltar</a> para a página inicial.
    <hr />   
    <form id="form1" runat="server">
        <div class="row">
            <div class="col-md-6">
                <asp:Label runat="server" ID="lblMensagem" Text="Deseja excluir o Produto?" CssClass="label label-danger" />
                <br />

                <br />
                <strong>ID:</strong>
                <asp:Label runat="server" ID="lblIdProduto" />
               
                <br />
                <strong>Nome:</strong>
                <asp:Label runat="server" ID="lblNome" />

                <br />
                <strong>Preço: </strong>
                <asp:Label runat="server" ID="lblPreco" />
                
                <br />
                <strong>Quantidade:</strong>
                <asp:Label runat="server" ID="lblQuantidade" />
                
                <br />
                <strong> Data do Cadastro: </strong>
                <asp:Label runat="server" ID="lblDataCadastro" />

                <br />
                <strong>Estoque de ID:</strong>
                <asp:Label runat="server" ID="lblEstoque" />

                <br />
                <br />
                <asp:Button runat="server" ID="BtnExcluir" Text="Exluir Produto" CssClass="btn btn-danger btn-md" OnClick="BtnExcluir_Click"/>               
            </div>
        </div>
    </form>
</body>
</html>
