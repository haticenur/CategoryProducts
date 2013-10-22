<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Panel.Master" AutoEventWireup="true" CodeBehind="CategoryForm.aspx.cs" Inherits="Client.Admin.CategoryForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>Kategori Ekle</h3>

    <table>
        <tr>
            <td>Kategori Adı</td>
            <td>
                <asp:TextBox ID="txtName" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Button ID="btnSave" OnClick="btnSave_Click" runat="server" Text="Kaydet" /></td>
        </tr>
    </table>

</asp:Content>
