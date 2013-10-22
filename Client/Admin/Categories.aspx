<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Panel.Master" AutoEventWireup="true" CodeBehind="Categories.aspx.cs" Inherits="Client.Admin.Categories" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>Kategoriler</h3>

    <table>
        <asp:Repeater ID="rptCategories" OnItemCommand="rptCategories_ItemCommand" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%# Eval("Name") %></td>
                    <td><a href="CategoryForm.aspx?catId=<%# Eval("Id") %>" style="margin-left:300px">Düzenle</a></td>
                    <td>
                        <asp:LinkButton ID="lnkDelete" CommandArgument='<%# Eval("Id") %>'   runat="server">Sil</asp:LinkButton></td>
                </tr>

            </ItemTemplate>
        </asp:Repeater>
    </table>

</asp:Content>
