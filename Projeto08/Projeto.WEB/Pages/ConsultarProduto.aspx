<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConsultarProduto.aspx.cs" Inherits="Projeto.WEB.Pages.ConsultarProduto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Consultar Produto</title>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <link href="../Content/bootstrap-theme.min.css" rel="stylesheet" />
</head>
<body class=" container">
    <h3>Consulta Produto</h3>
    <a href="/Default.aspx">Voltar</a> para a pagina inicial
    <hr />
    <form id="form1" runat="server">
        <div class="row">
            <div class="col-md-12">
                <asp:Label ID="lblmensagem" runat="server" />
                <asp:GridView ID="gridProduto" runat="server"
                    CssClass="table table-hover" GridLines="None" AutoGenerateColumns="false">
                    <Columns>
                        
                        <asp:TemplateField HeaderText="ID">                           
                            <ItemTemplate>
                                <%# Eval("IdProduto")%>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Nome">                            
                            <ItemTemplate>
                                <%# Eval("Nome")%>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Preço">
                            <ItemTemplate>
                                <%# Eval("Preco")%>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Quantidade">
                            <ItemTemplate>
                                <%# Eval("Quantidade")%>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Data Cadastro">
                            <ItemTemplate>
                                <%# Eval("DataCadastro")%>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="ID do Estoque">
                            <ItemTemplate>
                                <%# Eval("Estoque.idEstoque")%>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <a href='/Pages/EdicaoProduto.aspx?id=<%# Eval("IdProduto") %>' class="btn btn-primary btn-block btn-sm">Editar</a>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <a href='/Pages/ExclusaoProduto.aspx?id=<%# Eval("IdProduto") %>' class="btn btn-danger btn-block btn-sm">Excluir</a> 
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </form>
</body>
</html>
