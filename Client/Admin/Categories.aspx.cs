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
    public partial class Categories : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Helper.Sayfalar = new List<string> {"Kategoriler","Tüm Kategoriler" };

            if (IsPostBack) return;

            Fill();


        }

        private void Fill()
        {
            CategoryBLL cb = new CategoryBLL();
            rptCategories.DataSource = cb.Get(x => x.IsActive == true).ToList();
            rptCategories.DataBind();
        }

        protected void rptCategories_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            int id = Convert.ToInt32(e.CommandArgument);

            CategoryBLL cb = new CategoryBLL();

            Category c = cb.Get(x => x.Id == id).FirstOrDefault();
            c.IsActive = false;

            cb.Update(c);

            Fill();

        }
    }
}