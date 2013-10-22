using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Client.Admin
{
    public partial class CategoryForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
            if (Request.QueryString["catId"] != null)
            {
                int id = Convert.ToInt32(Request.QueryString["catId"]);
                CategoryBLL cb = new CategoryBLL();
                Category c = cb.Get(x => x.Id == id).FirstOrDefault();

                txtName.Text = c.Name;
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["catId"]);
            CategoryBLL cb = new CategoryBLL();
            if (Request.QueryString["catId"] == null)
            {
                Category c = new Category();
                c.Name = txtName.Text;
                c.IsActive = true;
                c.Date = DateTime.Now;

                cb.Add(c);
            }

            else
            {
                Category c = cb.Get(x => x.Id == id).FirstOrDefault();
                c.Name = txtName.Text;
                c.IsActive = true;
                c.Date = DateTime.Now;
                cb.Update(c);
            }

            Response.Redirect("Categories.aspx");


        }
    }
}