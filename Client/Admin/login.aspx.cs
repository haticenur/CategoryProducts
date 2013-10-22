using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace Client.Admin
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["logout"]=="true")
            {
                FormsAuthentication.SignOut();
                Session.Abandon();
                Response.Redirect("login.aspx");
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (Membership.ValidateUser(txtUsername.Text, txtPassword.Text) & Roles.IsUserInRole(txtUsername.Text,"Admin"))
            {
                FormsAuthentication.RedirectFromLoginPage(txtUsername.Text, true);
            }
            else
            {
                ltrError.Text = "Hatalı giriş";
            }
        }
    }
}