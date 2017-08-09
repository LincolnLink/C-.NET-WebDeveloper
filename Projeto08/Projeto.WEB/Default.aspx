<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Projeto.WEB.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Lincoln Projeto</title>
    <link href="Content/bootstrap-theme.min.css" rel="stylesheet" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body class="container">   
    <form id="form1" runat="server">
        <div>
            <p>Selecione a operação desejada: </p>
            <ul>
                <li><a href="/Pages/CadastroEstoque.aspx">Cadastrar Estoques</a></li>
                <li><a href="/Pages/ConsultaEstoque.aspx">Consultar Estoques</a></li>
            </ul>
            <ul>
                <li><a href="/Pages/CadastroProduto.aspx">Cadastrar Produtos</a></li>
                <li><a href="/Pages/ConsultaProduto.aspx">Consulta Produtos</a></li>
            </ul>


        </div>
    </form>
</body>
</html>
