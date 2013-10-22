<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucLeftMenu.ascx.cs" Inherits="Client.Admin.ucLeftMenu" %>



<div style="float: left; width: 250px; height: 300px; font-size: 20pt;margin-top:60px">


    <% if (Client.Models.Helper.Sayfalar[0] == "Kategoriler")
       { %>
    <li><a href="CategoryForm.aspx" style="text-decoration: none; color: black; font-size: 20pt; list-style: none">Kategori Ekle</a></li>
    <li><a href="Categories.aspx" style="text-decoration: none; color: black; font-size: 20pt; list-style: none">Tüm Kategoriler</a></li>
    <%} %>


    <%  if (Client.Models.Helper.Sayfalar[0] == "Ürünler")
        {%>
    <li><a href="ProductForm.aspx" style="text-decoration: none; color: black; font-size: 20pt;list-style: none">Ürün Ekle</a></li>
    <li><a href="Products.aspx" style="text-decoration: none; color: black; font-size: 20pt;list-style: none">Tüm Ürünler</a></li>


    <% } %>
</div>






