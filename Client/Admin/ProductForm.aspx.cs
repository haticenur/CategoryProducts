using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Client.Admin
{
    public partial class ProductForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
            CategoryBLL cb = new CategoryBLL();
            ddlCategories.DataTextField = "Name";
            ddlCategories.DataValueField = "Id";
            ddlCategories.DataSource = cb.Get(x => x.IsActive == true).ToList();
            ddlCategories.DataBind();

            if (Request.QueryString["productId"]!=null)
            {
                int id = Convert.ToInt32(Request.QueryString["productId"]);
                ProductBLL pb = new ProductBLL();
                Product p = pb.Get(x => x.Id == id).FirstOrDefault();

                txtName.Text = p.Name;
                txtPrice.Text = p.Price.ToString();
                txtStock.Text = p.Stock.ToString();
                txtDetail.Text = p.Detail;
            }

            
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {


            int catId =Convert.ToInt32(ddlCategories.SelectedValue);
            if (Request.QueryString["productId"]==null)
            {
                ProductBLL pb = new ProductBLL();
                Product p = new Product();
                p.CategoryId = catId;
                p.Name = txtName.Text;
                p.Price = Convert.ToDecimal(txtPrice.Text);
                p.Stock = Convert.ToByte(txtStock.Text);
                p.Date = DateTime.Now;
                p.IsActive = true;
                p.Detail = txtDetail.Text;

                string fileName = Guid.NewGuid().ToString().Replace("-", "");
                string ext = Path.GetExtension(fl.FileName);
                fileName += ext;
                fl.SaveAs(MapPath("~/ProductImages/" + fileName));

                p.Image = fileName;

                pb.Add(p);  
            }
            else
            {
                int id = Convert.ToInt32(Request.QueryString["productId"]);
                ProductBLL pb = new ProductBLL();
                Product p = pb.Get(x => x.Id == id).FirstOrDefault();

                p.Name = txtName.Text;
                p.Price = Convert.ToDecimal(txtPrice.Text);
                p.Stock = Convert.ToByte(txtStock.Text);
                p.Date = DateTime.Now;
                p.IsActive = true;
                p.Detail = txtDetail.Text;

                string fileName = Guid.NewGuid().ToString().Replace("-", "");
                string ext = Path.GetExtension(fl.FileName);
                fileName += ext;
                fl.SaveAs(MapPath("~/ProductImages/" + fileName));

                p.Image = fileName;

                pb.Update(p);
            }
            Response.Redirect("Products.aspx");
            

        }
    }
}