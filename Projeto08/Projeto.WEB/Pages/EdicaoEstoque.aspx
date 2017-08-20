<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EdicaoEstoque.aspx.cs" Inherits="Projeto.WEB.Pages.EdicaoEstoque" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Edicão Estoque</title>
    <link href="../Content/bootstrap-theme.min.css" rel="stylesheet" />
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body class="container">
    <h3>Editar Estoque</h3>
    <a href="/Default.aspx">Voltar</a> para a página inicial
    <hr />
    <form id="form1" runat="server">
        <div class="col-md-6">            
            <label><strong>Codigo do Estoque: </strong></label>
            <asp:TextBox ID="txtCodigo" runat="server"
                ReadOnly="true" CssClass="form-control"/>
            <br />
            <label><strong>Nome do Produto:</strong> </label>
            <asp:TextBox ID="txtNome" runat="server" CssClass=" form-control" />
            <asp:Label ID="lblErroNome" runat="server" CssClass="text-danger"></asp:Label>
            <br />
            <label><strong>Descrição</strong></label>
            <asp:TextBox ID="txtDescricao" runat="server" CssClass="form-control" TextMode="MultiLine" />
            <asp:Label ID="lblErroDescricao" runat="server" CssClass="text-danger" />
            <br />
            <asp:button ID="btnEdicao" runat="server" 
                Text="Atualizar Estoque" CssClass="btn btn-primary"
                Onclick="btnEdicao_Click"/>
            <br />
            <br />
            <asp:label ID="lblMensagem" runat="server" />
        </div>
    </form>
</body>
</html>
