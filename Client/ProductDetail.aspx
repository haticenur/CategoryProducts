    <%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="ProductDetail.aspx.cs" Inherits="Client.ProductDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="title">
        <h3><a href="Products.aspx?catId=<%= product.CategoryId %>"><%= product.Category.Name%> ></a> <%= product.Name %></h3> 
    </div>

    <div class="feat_prod_box_details">

        <div class="prod_img">
            <img src="ProductImages/<%=product.Image %>" width="130px" alt="" title="" border="0" />
            <br />
           
        </div>

        <div >
            <div ></div>
            <div >
                <div >
                    <strong>Stok : </strong><span class="red"><%= product.Stock %></span>
                </div>
                <div class="price"><strong>Fiyat:</strong> <span class="red"><%= String.Format("{0:0.00}",product.Price) %> TL</span></div>
            </div>

        </div>
        
    </div>

</asp:Content>
