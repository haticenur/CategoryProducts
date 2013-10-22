<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Panel.Master" AutoEventWireup="true" CodeBehind="ProductForm.aspx.cs" Inherits="Client.Admin.ProductForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

   

    <table>
        <tr><td></td>
            <td> <asp:DropDownList ID="ddlCategories" runat="server">
    </asp:DropDownList></td>
        </tr>
        <tr>
            <td>Ürün Adı</td>
            <td>
                <asp:TextBox ID="txtName" runat="server"></asp:TextBox></td>
        </tr>
         <tr>
            <td>Fiyat</td>
            <td>
                <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox></td>
        </tr>
         <tr>
            <td>Stok</td>
            <td>
                <asp:TextBox ID="txtStock" runat="server"></asp:TextBox></td>
        </tr>
         <tr>
            <td>Detay</td>
            <td>
                <asp:TextBox ID="txtDetail" TextMode="MultiLine" runat="server"></asp:TextBox></td>
        </tr>
         <tr>
            <td>Resim</td>
            <td>
                <asp:FileUpload ID="fl" runat="server" /></td>
        </tr>
         <tr>
            <td></td>
            <td>
                <asp:Button ID="btnSave" OnClick="btnSave_Click" runat="server" Text="Kaydet" /></td>
        </tr>
    </table>


</asp:Content>
