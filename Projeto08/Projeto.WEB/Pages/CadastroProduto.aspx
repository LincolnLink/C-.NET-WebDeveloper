<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastroProduto.aspx.cs" Inherits="Projeto.WEB.Pages.CadastroProduto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Cadastro Produto</title>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <link href="../Content/bootstrap-theme.min.css" rel="stylesheet" />
</head>
<body class="container">
    <h3>Cadastrar Produto</h3>
    <a href="/Default.aspx">Voltar</a> para a pagina inicial!
    <hr />
    <form id="form1" runat="server" class="row">
        <div class="col-md-6">
            <label>Nome do Produto</label>
            <asp:TextBox runat="server" ID="txtNome" CssClass="form-control"/>
            <asp:Label runat="server" ID="lblErroNome" CssClass="label label-danger" />
            <br />
           
            <label>Preço do Produto</label>
            <asp:TextBox runat="server" ID="txtPreco" CssClass="form-control" />
            <asp:Label runat="server" ID="lblErroPreco" CssClass="label label-danger" />
            <br />
          
            <label>Quanditade do Produto</label>
            <asp:TextBox runat="server" ID="txtQuantidade" CssClass="form-control" />
            <asp:Label runat="server" ID="lblErroQuantidade" CssClass="label label-danger"/>
            <br />
           
            <label>Escolha um estoque</label>
            <asp:DropDownList runat="server" ID="ddlEstoque" CssClass="form-control" />
            <asp:Label runat="server" ID="lblErroEstoque" CssClass="label label-danger" />
            <br />
            <br />
            <asp:Button runat="server" ID="BtnCadastrar" Text="Cadastrar"
                CssClass="btn btn-primary btn-sm" OnClick="BtnCadastrar_Click" />
            <asp:Label runat="server" ID="lblMessagem" CssClass="" />
        </div>
    </form>
</body>
</html>
