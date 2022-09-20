using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            //Response.Cookies.Add(userInfo);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String userName = TextBox1.Text;
            String password = TextBox2.Text;
            HttpCookie userInfo = new HttpCookie("userInfo" + userName);
            Response.Cookies.Add(userInfo);
            Session.Add("secret", password);
            Response.Redirect("WebForm2.aspx?userName="+userName);
            
        }
    }
}