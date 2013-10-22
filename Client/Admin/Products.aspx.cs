using BLL;
using Client.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Client.Admin
{
    public partial class Products : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
            Helper.Sayfalar = new List<string>() { "Ürünler", "Tüm Ürünler" };
            Fill();
        }

        private void Fill()
        {
            ProductBLL pb = new ProductBLL();

            rptProducts.DataSource = pb.Get(x => x.IsActive == true).ToList();
            rptProducts.DataBind();
        }

        protected void rptProducts_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            int id = Convert.ToInt32(e.CommandArgument);

            ProductBLL pb = new ProductBLL();
            Product p = pb.Get(x => x.Id == id).FirstOrDefault();

            p.IsActive = false;
            pb.Update(p);

            Fill();


        }
    }
}