<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Panel.Master" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="Client.Admin.Products" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h3>Ürünler</h3>


        <asp:Repeater ID="rptProducts" OnItemCommand="rptProducts_ItemCommand" runat="server">
            <HeaderTemplate>
                <headertemplate>
                <table border="1">
                    <thead>
                        <tr>
                            <th>Kategori 
                            </th>
                           <th>Ürün Adı</th>
                            <th>Fiyat
                            </th>
                            <th>Stok
                            </th>
                            <th>Detay</th>
                        </tr>
                    </thead>
            </headertemplate>
            </HeaderTemplate>
            <ItemTemplate>
                <tr style="background-color:ActiveCaption">
                    <td><%# Eval("Category.Name") %></td>
                    <td><%# Eval("Name") %></td>
                    <td><%# Eval("Price") %></td>
                    <td><%# Eval("Stock") %></td>
                    <td><%# Eval("Detail") %></td>
                    <td><a href="ProductForm.aspx?productId=<%# Eval("Id") %>"">Düzenle</a></td>
                    <td>
                        <asp:LinkButton ID="lnkDelete" CommandArgument='<%# Eval("Id") %>' runat="server">Sil</asp:LinkButton></td>
                </tr>
            </ItemTemplate>
            <SeparatorTemplate>
                <tr style="background-color: black">
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>

                </tr>
            </SeparatorTemplate>
            <AlternatingItemTemplate>
                <tr style="background-color:bisque">
                    <td><%# Eval("Category.Name") %></td>
                    <td><%# Eval("Name") %></td>
                    <td><%# Eval("Price") %></td>
                    <td><%# Eval("Stock") %></td>
                    <td><%# Eval("Detail") %></td>
                    <td><a href="ProductForm.aspx?productId=<%# Eval("Id") %>">Düzenle</a></td>
                    <td>
                        <asp:LinkButton ID="lnkDelete" CommandArgument='<%# Eval("Id") %>' runat="server">Sil</asp:LinkButton></td>
                </tr>
            </AlternatingItemTemplate>
            <FooterTemplate>
                </table>
            </FooterTemplate>

        </asp:Repeater>

 

</asp:Content>
