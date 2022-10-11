using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string myConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlConnection myConnection = new SqlConnection(myConnectionString);
            myConnection.Open();
            string MyQuery = "spGetUsers";
            DataSet myDataSet = new DataSet();
            SqlCommand myCommand = new SqlCommand(MyQuery);
            myCommand.Connection = myConnection;
            myCommand.CommandType = CommandType.Text;

            SqlDataAdapter myAdapter = new SqlDataAdapter(myCommand);
            myAdapter.Fill(myDataSet);
            myConnection.Close();

            //GridView1.DataSource = myDataSet.Tables[0];
            //GridView1.DataBind();
            //Response.Cookies.Add(userInfo);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String userName = TextBox1.Text;
            String password = TextBox2.Text;
            String dob = TextBox3.Text;
            if( userName != "")
            {
                string myConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
                SqlConnection myConnection = new SqlConnection(myConnectionString);
                myConnection.Open();
                string MyQuery = "spInsertNewUser";
                Response.Write(MyQuery);
                SqlCommand myCommand = new SqlCommand(MyQuery);
                SqlParameter[] myParameters = new SqlParameter[3];
                myParameters[0] = new SqlParameter("username", userName);
                myParameters[1] = new SqlParameter("pwd", password);
                myParameters[2] = new SqlParameter("dateOfBirth", dob);
                myCommand.Parameters.AddRange(myParameters);
                myCommand.Connection = myConnection;
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.ExecuteNonQuery();
                //HttpCookie userInfo = new HttpCookie("userInfo" + userName);
                //Response.Cookies.Add(userInfo);
                //Session.Add("secret", password);
                
            }
            Response.Redirect("WebForm3.aspx?userName=" + userName);

        }
    }
}