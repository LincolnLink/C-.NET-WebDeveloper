<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ExclusaoEstoque.aspx.cs" Inherits="Projeto.WEB.Pages.ExclusaoEstoque" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>   
    <title>Excluir Estoque</title>
    <link href="../Content/bootstrap-theme.min.css" rel="stylesheet" />
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body class="container">
    <h3>Excluir Estoque</h3>
    <a href="/Default.aspx">Voltar</a> para a página inicial
    <hr />
    <form id="form1" runat="server">
    <div class="col-md-6">
        <div class="alert alert-danger" >Deseja excluir o estoque selecionado?</div>
    <br />
    <br />
        <div class="control-label"><strong>Codigo do Estoque: </strong></div>
        <asp:Label ID="lblCodigo" runat="server" />
        <br />
        <br />
        <div class="control-label"><strong>Nome do Estoque: </strong></div>
        <asp:Label ID="lblNome" runat="server" />
        <br />
        <br />
        <div class="control-label"><strong>Descrição: </strong></div>
        <asp:Label ID="lblDescricao" runat="server" />
        <br />
        <br />
        <asp:Button ID="btnExclusao" runat="server" Text="Confirmar Exclusão" CssClass="btn btn-danger" OnClick="btnExclusao_Click"/>
        <br />
        <br />
        <asp:Label ID="lblMensagem" runat="server" />        
    </div>
    </form>
</body>
</html>
