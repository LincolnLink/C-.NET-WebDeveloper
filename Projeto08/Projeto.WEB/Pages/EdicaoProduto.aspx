<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EdicaoProduto.aspx.cs" Inherits="Projeto.WEB.Pages.EdicaoProduto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Edição do Produto</title>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <link href="../Content/bootstrap-theme.min.css" rel="stylesheet" />
</head>
<body class="container">
    <h3>Editar o Produto</h3>
    <a href="/Pages/ConsultarProduto.aspx">Voltar</a> a página inicial.
    <hr />
    <form id="form1" runat="server">
        <div class="row">
            <div class="col-md-6">
                <strong>ID: </strong>
                <asp:TextBox runat="server" ID="txtId" CssClass="form-control" ReadOnly="true" />
                <br />
                <strong>Nome: </strong>
                <asp:TextBox runat="server" ID="txtNome" CssClass="form-control" />
                <asp:Label runat="server" ID="lblErroNome" CssClass="label label-danger" />
                <br />
                <strong>Preço: </strong>
                <asp:TextBox runat="server" ID="txtPreco" CssClass="form-control" />
                <asp:Label runat="server" ID="lblErroPreco" CssClass="label label-danger" />
                <br />
                <strong>Quantidade: </strong>
                <asp:TextBox runat="server" ID="txtQuantidade" CssClass="form-control" />
                <asp:Label runat="server" ID="lblErroQuantidade" CssClass="label label-danger" />
                <strong>Data Cadastrada: </strong>
                <br />
                <br />
                <asp:TextBox runat="server" ID="txtDataCadastrada" CssClass="form-control" ReadOnly="true" />
                <br />
                <strong>Estoque: </strong>
                <asp:DropDownList runat="server" ID="ddlEstoque" CssClass="form-control" />
                <asp:Label runat="server" ID="lblErroEstoque" CssClass="label label-danger" />
                <br />
                <br />
                <asp:Button runat="server" ID="BtnEditar" CssClass="btn btn-success"  Text="Editar Produto" OnClick="BtnEditar_Click" />                
                <br />
                <asp:Label runat="server" ID="lblMessagem" CssClass="danger alert-danger" />
            </div>
        </div>
    </form>
</body>
</html>
