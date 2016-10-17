<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Vendas.aspx.cs" Inherits="Vendas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style15 {
            font-size: x-large;
        }
        .auto-style16 {
            width: 100%;
        }
        .auto-style20 {
            text-align: right;
            height: 45px;
        }
        .auto-style26 {
            width: 948px;
            height: 31px;
            text-align: right;
        }
        .auto-style27 {
            width: 731px;
            height: 31px;
        }
        .auto-style28 {
            width: 827px;
            height: 31px;
        }
        .auto-style29 {
            width: 1024px;
            height: 53px;
            text-align: center;
        }
        .auto-style30 {
            width: 918px;
            height: 53px;
            text-align: center;
        }
        .auto-style31 {
            width: 827px;
            height: 53px;
        }
        .auto-style32 {
            width: 948px;
            height: 33px;
            text-align: right;
        }
        .auto-style33 {
            width: 731px;
            height: 33px;
        }
        .auto-style34 {
            width: 827px;
            height: 33px;
        }
        .auto-style35 {
            width: 100%;
            height: 59px;
        }
        .auto-style36 {
            margin-left: 0px;
        }
    .auto-style38 {
        width: 291px;
        height: 53px;
        text-align: center;
    }
        .auto-style39 {
            width: 451px;
            height: 53px;
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <span class="auto-style15">&nbsp;Vendas</span>:&nbsp;&nbsp;<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:AdegaConnectionString %>" DeleteCommand="DELETE FROM [Cliente] WHERE [id] = @id" InsertCommand="INSERT INTO [Cliente] ([id], [Nome], [Endereco], [Cidade]) VALUES (@id, @Nome, @Endereco, @Cidade)" SelectCommand="SELECT * FROM [Cliente]" UpdateCommand="UPDATE [Cliente] SET [Nome] = @Nome, [Endereco] = @Endereco, [Cidade] = @Cidade WHERE [id] = @id">
            <DeleteParameters>
                <asp:Parameter Name="id" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="id" Type="Int32" />
                <asp:Parameter Name="Nome" Type="String" />
                <asp:Parameter Name="Endereco" Type="String" />
                <asp:Parameter Name="Cidade" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="Nome" Type="String" />
                <asp:Parameter Name="Endereco" Type="String" />
                <asp:Parameter Name="Cidade" Type="String" />
                <asp:Parameter Name="id" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:AdegaConnectionString %>" DeleteCommand="DELETE FROM [Bebidas] WHERE [id] = @id" InsertCommand="INSERT INTO [Bebidas] ([id], [Nome], [Preço], [Fornecedor], [Descricao], [Quantidade]) VALUES (@id, @Nome, @Preço, @Fornecedor, @Descricao, @Quantidade)" SelectCommand="SELECT * FROM [Bebidas]" UpdateCommand="UPDATE [Bebidas] SET [Nome] = @Nome, [Preço] = @Preço, [Fornecedor] = @Fornecedor, [Descricao] = @Descricao, [Quantidade] = @Quantidade WHERE [id] = @id">
            <DeleteParameters>
                <asp:Parameter Name="id" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="id" Type="Int32" />
                <asp:Parameter Name="Nome" Type="String" />
                <asp:Parameter Name="Preço" Type="Single" />
                <asp:Parameter Name="Fornecedor" Type="Int32" />
                <asp:Parameter Name="Descricao" Type="String" />
                <asp:Parameter Name="Quantidade" Type="Int32" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="Nome" Type="String" />
                <asp:Parameter Name="Preço" Type="Single" />
                <asp:Parameter Name="Fornecedor" Type="Int32" />
                <asp:Parameter Name="Descricao" Type="String" />
                <asp:Parameter Name="Quantidade" Type="Int32" />
                <asp:Parameter Name="id" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </p>
    <table class="auto-style35">
        <tr>
            <td>
                <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="id" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None" Width="229px">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" SortExpression="id" />
                        <asp:BoundField DataField="Nome" HeaderText="Nome" SortExpression="Nome" />
                        <asp:BoundField DataField="Endereco" HeaderText="Endereco" SortExpression="Endereco" />
                        <asp:BoundField DataField="Cidade" HeaderText="Cidade" SortExpression="Cidade" />
                        <asp:CommandField ShowSelectButton="True" />
                    </Columns>
                    <EditRowStyle BackColor="#2461BF" />
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#EFF3FB" />
                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#F5F7FB" />
                    <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                    <SortedDescendingCellStyle BackColor="#E9EBEF" />
                    <SortedDescendingHeaderStyle BackColor="#4870BE" />
                </asp:GridView>
            </td>
            <td>
                <asp:GridView ID="GridView2" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" CssClass="auto-style36" DataKeyNames="id" DataSourceID="SqlDataSource2" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" SortExpression="id" />
                        <asp:BoundField DataField="Nome" HeaderText="Nome" SortExpression="Nome" />
                        <asp:BoundField DataField="Preço" HeaderText="Preço" SortExpression="Preço" />
                        <asp:BoundField DataField="Fornecedor" HeaderText="Fornecedor" SortExpression="Fornecedor" />
                        <asp:BoundField DataField="Descricao" HeaderText="Descricao" SortExpression="Descricao" />
                        <asp:BoundField DataField="Quantidade" HeaderText="Quantidade" SortExpression="Quantidade" />
                        <asp:CommandField ShowSelectButton="True" />
                    </Columns>
                    <EditRowStyle BackColor="#2461BF" />
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#EFF3FB" />
                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#F5F7FB" />
                    <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                    <SortedDescendingCellStyle BackColor="#E9EBEF" />
                    <SortedDescendingHeaderStyle BackColor="#4870BE" />
                </asp:GridView>
            </td>
        </tr>
    </table>
    <p>
        <table class="auto-style16">
            <tr>
                <td class="auto-style20" colspan="5"></td>
            </tr>
            <tr>
                <td class="auto-style32" colspan="2">Cliente:</td>
                <td class="auto-style33" colspan="2">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox2" ErrorMessage="Campo Cliente é obrigatorio"></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style34"></td>
            </tr>
            <tr>
                <td class="auto-style32" colspan="2">Bebidas:</td>
                <td class="auto-style33" colspan="2">
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox3" ErrorMessage="Campo Bebidas é obrigatorio"></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style34"></td>
            </tr>
            <tr>
                <td class="auto-style32" colspan="2">Quantidade:</td>
                <td class="auto-style33" colspan="2">
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox4" ErrorMessage="Campo Quantidade é obrigatorio"></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style34"></td>
            </tr>
            <tr>
                <td class="auto-style26" colspan="2"></td>
                <td class="auto-style27" colspan="2"></td>
                <td class="auto-style28"></td>
            </tr>
            <tr>
                <td class="auto-style29">
                    &nbsp;</td>
                <td class="auto-style39">
                    <asp:Button ID="btnConcluir" runat="server" CssClass="btn-success" Text="Concluir" />
                </td>
                <td class="auto-style38">
                    <asp:Button ID="btnCancela" runat="server" CssClass="btn-danger" Text="Cancela" />
                </td>
                <td class="auto-style30">
                    &nbsp;</td>
                <td class="auto-style31"></td>
            </tr>
        </table>
    </p>
    <p>
        &nbsp;</p>
</asp:Content>

