using System;
using System.Web;
using System.Web.UI;

namespace Esercitazione_Sett15_G2
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["ASPNET_COOKIE"] != null)
            {
                username_title.InnerText = "Benvenuto, " + Request.Cookies["ASPNET_COOKIE"]["username"];
            }
            else
            {
                Response.Redirect("Default");
            }

        }

        protected void LogoutButton_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("ASPNET_COOKIE");
            cookie.Expires = DateTime.Now.AddDays(-1);
            Response.Cookies.Add(cookie);
            Response.Redirect("Default");
        }
    }
}