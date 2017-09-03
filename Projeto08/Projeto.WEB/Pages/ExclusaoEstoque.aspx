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
    <a href="/Pages/ConsultarEstoque.aspx">Voltar</a> para a página inicial
    <hr />
    <form id="form1" runat="server">
    <div class="col-md-6">
        <div class="alert alert-danger" >Deseja excluir o estoque selecionado?</div>
    
        <strong>Codigo do Estoque: </strong>
        <asp:Label ID="lblCodigo" runat="server" />
        <br />
    <br />
       <strong>Nome do Estoque: </strong>
        <asp:Label ID="lblNome" runat="server" />
        <br />
    <br />
        <strong>Descrição: </strong>
        <asp:Label ID="lblDescricao" runat="server" />
        <br />
        <br />
   
        <asp:Button ID="BtnExclusao" runat="server" Text="Confirmar Exclusão" CssClass="btn btn-danger" OnClick="BtnExclusao_Click"/>      
        <br />
        <br />
        <asp:Label ID="lblMensagem" runat="server" />        
    </div>
    </form>
</body>
</html>
