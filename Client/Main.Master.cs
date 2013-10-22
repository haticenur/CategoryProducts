using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
namespace Client
{
    public partial class Main : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CategoryBLL cb = new CategoryBLL();

            rptCategories.DataSource = cb.Get(x => x.IsActive == true).ToList();
            rptCategories.DataBind();

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (Membership.ValidateUser(txtLoginName.Text, txtLoginPassword.Text) & Roles.IsUserInRole(txtLoginName.Text, "User"))
            {
                FormsAuthentication.RedirectFromLoginPage(txtLoginName.Text, true);
                Response.Redirect(Request.RawUrl);
            }
            else
            {
                ltrError.Text = "Kullanıcı adı veya şifre yanlış";
            }

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Membership.CreateUser(txtName.Text, txtPass.Text, txtEmail.Text);
                Roles.AddUserToRole(txtName.Text, "User");
                FormsAuthentication.SetAuthCookie(txtName.Text, true);
                Response.Redirect(Request.RawUrl);


            }
            catch (MembershipCreateUserException ex)
            {
                ltrError.Text = GetErrorMessage(ex.StatusCode);
            }
        }

        public string GetErrorMessage(MembershipCreateStatus status)
        {
            switch (status)
            {
                case MembershipCreateStatus.DuplicateUserName:
                    return "Bu kullanıcı adı kullanılmakta,Başka bir kullanıcı adı deneyin";

                case MembershipCreateStatus.DuplicateEmail:
                    return "Bu  email kullanılmakta,Başka bir  email deneyin";

                case MembershipCreateStatus.InvalidPassword:
                    return "Geçersiz şifre";

                case MembershipCreateStatus.InvalidEmail:
                    return "Geçersiz email";
                case MembershipCreateStatus.InvalidUserName:
                    return "Geçersiz kullanıcı adı";

                //case MembershipCreateStatus.InvalidAnswer:
                //    return "The password retrieval answer provided is invalid. Please check the value and try again.";

                //case MembershipCreateStatus.InvalidQuestion:
                //    return "The password retrieval question provided is invalid. Please check the value and try again.";



                //case MembershipCreateStatus.ProviderError:
                //    return "The authentication provider returned an error. Please verify your entry and try again. If the problem persists, please contact your system administrator.";

                //case MembershipCreateStatus.UserRejected:
                //    return "The user creation request has been canceled. Please verify your entry and try again. If the problem persists, please contact your system administrator.";

                default:
                    return "An unknown error occurred. Please verify your entry and try again. If the problem persists, please contact your system administrator.";
            }
        }
    }
}