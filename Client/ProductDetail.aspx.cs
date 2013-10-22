using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Client
{
    public partial class ProductDetail : System.Web.UI.Page
    {

        public Product product;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["productId"]==null)
            {
                Response.Redirect("Products.aspx");
            }
            else
            {
                int id = Convert.ToInt32(Request.QueryString["productId"]);

                ProductBLL pb = new ProductBLL();
                product = pb.Get(x => x.Id == id).FirstOrDefault();


            }
        }
    }
}