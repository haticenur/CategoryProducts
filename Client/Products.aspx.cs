using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Client
{
    public partial class Products : System.Web.UI.Page
    {
        
        private int SayfaNumarasi
        {
            get
            {
                if (ViewState["SayfaNumarasi"] != null)
                    return Convert.ToInt32(ViewState["SayfaNumarasi"]);
                return 0;
            }
            set
            {
                ViewState["SayfaNumarasi"] = value;
            }
        }
        private int SayfaAdedi
        {
            get
            {
                if (ViewState["SayfaAdedi"] != null)
                    return Convert.ToInt32(ViewState["SayfaAdedi"]);
                return 0;
            }
            set { ViewState["SayfaAdedi"] = value; }
        }
        public PagedDataSource SayfadakiVeri { get; set; }

       

        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Request.QueryString["catId"] == null)
            //{
                SayfaKaydiniGetir();
            //}
            //else
            //{
            //    ProductBLL pb = new ProductBLL();
            //    int id = Convert.ToInt32(Request.QueryString["catId"]);

            //    btnGeri.Enabled = false;
            //    btnIleri.Enabled = false;//kategori 

            //    rptProducts.DataSource = pb.Get(x => x.IsActive == true & x.Id == id).ToList();
            //    rptProducts.DataBind();

            //}
         
        }
        private void SayfaKaydiniGetir()
        {
            ProductBLL pb = new ProductBLL();
            if (Request.QueryString["catId"] == null)
            {
                SayfadakiVeri = new PagedDataSource()
                {
                    DataSource = pb.Get(x => x.IsActive == true).ToList(),
                    AllowPaging = true,
                    PageSize = 4,
                    CurrentPageIndex = SayfaNumarasi
                };
            }
            else
            {
                int id = Convert.ToInt32(Request.QueryString["catId"]);
                SayfadakiVeri = new PagedDataSource()
                {
                    DataSource = pb.Get(x => x.IsActive == true & x.Id == id).ToList(),
                    AllowPaging = true,
                    PageSize = 4,
                    CurrentPageIndex = SayfaNumarasi
                };
            }
            //
            rptProducts.DataSource = SayfadakiVeri;
            rptProducts.DataBind();

            SayfaAdedi = SayfadakiVeri.PageCount - 1;
            //
            lbSayfaBilgi.Text = "Sayfa " + (SayfadakiVeri.CurrentPageIndex + 1) + "/" + SayfadakiVeri.PageCount + " - Kayıt Sayısı " + (SayfadakiVeri.DataSourceCount);
            //
            btnGeri.Enabled = !SayfadakiVeri.IsFirstPage;
            btnIleri.Enabled = !SayfadakiVeri.IsLastPage;

        }

        
 
        protected void btnGeri_Click(object sender, EventArgs e)
        {
            SayfaNumarasi -= 1;
            SayfaKaydiniGetir();
        
        }

        protected void btnIleri_Click(object sender, EventArgs e)
        {
            SayfaNumarasi += 1;
            SayfaKaydiniGetir();
        }
        //protected void Page_Load(object sender, EventArgs e)
        //{


           
            

        //}
    }
}