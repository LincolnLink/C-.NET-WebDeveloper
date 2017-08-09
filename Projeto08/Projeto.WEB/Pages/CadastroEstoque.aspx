<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastroEstoque.aspx.cs" Inherits="Projeto.WEB.Pages.CadastroEstoque" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Cadastrar Estoque</title>
    <link href="../Content/bootstrap-theme.min.css" rel="stylesheet" />
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body class="container">
    <h3>Cadastro de Estoques</h3>
    <a href="/Default.aspx">Voltar</a> para a página inicial.
    <hr />
    <form id="form1" runat="server">
        <div class="col-md-4">
            <label>Nome do Estoque: </label>
            <asp:TextBox ID="txtNome" runat="server" CssClass="form-control" />
            <asp:Label ID="lblErroNome" runat="server" CssClass="text-danger" />
            <br />

            <label>Descrição:</label>
            <asp:TextBox ID="txtDescricao" runat="server" CssClass="form-control" TextModel="MultiLine" />
            <asp:Label ID="lblErroDescricao" runat="server" CssClass="text-danger" />
            <br />

            <asp:Button ID="btnCadastro" runat="server" Text="Cadastrar Estoque" CssClass="btn btn-success" OnClick="btnCadastro_Click"/>
            <br />
            <br />
            <asp:Label ID="lblMensagem" runat="server" />
        </div>
    </form>
</body>
</html>
