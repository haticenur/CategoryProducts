<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="Client.Products" %>

<asp:content id="Content1" contentplaceholderid="head" runat="server">
</asp:content>
<asp:content id="Content2" contentplaceholderid="ContentPlaceHolder1" runat="server">
    <div style="width:500px; height:50px;">
               
                <div style="width:500px; height:100%; float:left; text-align:center">
                    <p><asp:Button ID="btnGeri" runat="server" OnClick="btnGeri_Click" Text="Geri" />
                    <asp:Button ID="btnIleri" runat="server" OnClick="btnIleri_Click" Text="İleri" /></p>
                   <p><asp:Label ID="lbSayfaBilgi" runat="server" Text=" "></asp:Label></p> 
                </div>
            

    <asp:Repeater ID="rptProducts" runat="server">
        <ItemTemplate>
            <div style="float: left; margin-left: 10px; width: 500px; height: 150px; margin-top: 25px; color: black; border-radius: 10px; background-color: antiquewhite">

                <div style="float: left; width: 200px; height: 120px;">
                    <img style="margin-top: 20px; margin-left: 20px" width="130" src="ProductImages/<%# Eval("Image") %>" alt="" title="" border="0"></a>
                   
                </div>
                <div>
                    <div>
                        <p><%# Eval("Name") %> (<%# Eval("Category.Name") %>)</p>
                        <p>Stok : <%# Eval("Stock") %></p>
                        <p>Fiyat : <%# Eval("Price","{0:0.00}") %> TL</p>
                        <a href="ProductDetail.aspx?productId=<%# Eval("Id") %>" style="margin-left: 200px">Detay</a>
                    </div>
                </div>
            </div>

        </ItemTemplate>
    </asp:Repeater>
<%--    <table>
        <tr>
            <td>
                <asp:PlaceHolder ID="plcPaging" runat="server" />
            </td>
        </tr>
    </table>--%>
     

</asp:content>
