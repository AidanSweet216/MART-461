using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie myCookie = Request.Cookies["userinfo"];
            String userName = Request.QueryString["userName"];
            String password = Session["secret"].ToString();
            message3.Text = password;
            lblMessage.Text = userName;
            message2.Text = myCookie.Value;
            //Response.Write(messageFromQueryString);
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}