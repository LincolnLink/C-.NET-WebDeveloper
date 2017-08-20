<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConsultarEstoque.aspx.cs" Inherits="Projeto.WEB.Pages.ConsultarEstoque" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Consultar Estoque</title>
    <link href="../Content/bootstrap-theme.min.css" rel="stylesheet" />
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body class="container">
  
    <h3>Consulta de Estoque</h3>
    <a href="/Default.aspx">Voltar</a> para a página inicial
    <hr />
   
    <form id="form1" runat="server">
        <div class="col-xs-12 col-md-6">
            <asp:label ID="lblMensagem" runat="server" />
            <br />
            <br />
            <asp:GridView ID="gridEstoque" runat="server" 
                GridLines="None" CssClass="table table-hover" 
                AutoGenerateColumns="false">
                <Columns>

                    <asp:TemplateField HeaderText="Código">
                        <ItemTemplate>
                            <%# Eval("IdEstoque") %>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Nome do Estoque">
                        <ItemTemplate>
                            <%# Eval("Nome") %>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Descrição">
                        <ItemTemplate>
                            <%# Eval("Descricao") %>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Operações">
                        <ItemTemplate>
                            <a href='/Pages/EdicaoEstoque.aspx?id=<%# Eval("IdEstoque") %>' class="btn btn-primary btn-sm btn-block">
                                Atualizar
                            </a>
                            <a href='/Pages/ExclusaoEstoque.aspx?id=<%# Eval("IdEstoque") %>' class="btn btn-danger btn-sm btn-block" >
                                Excluir
                            </a>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
