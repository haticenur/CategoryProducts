<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Panel.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Client.Admin.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <table>
        <tr>
            <td>
                <asp:TextBox ID="txtUsername"  placeholder="Kullanıcı Adı" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="txtPassword"  TextMode="Password" placeholder="Şifre" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                <asp:Literal ID="ltrError" runat="server"></asp:Literal></td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnLogin" OnClick="btnLogin_Click" runat="server" Text="Giriş" /></td>
        </tr>
    </table>
</asp:Content>
