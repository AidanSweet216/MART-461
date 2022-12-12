using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GalleryProject
{
    public partial class Admin2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            fillTable();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String videoLinks = TextBox1.Text;
            Response.Write(videoLinks);
            string myQuery = "InsertVideo";
            Database myData = new Database();
            SqlParameter[] myparameters = new SqlParameter[1];
            myparameters[0] = new SqlParameter("videoLink", videoLinks);
            myData.RunQueryWithParameters(myQuery, myparameters);
            fillTable();
        }

        private void fillTable()
        {
            Database myData = new Database();

            string MyQuery = "GetVideos";
            DataSet myDataSet = myData.getQueryWithoutParameters(MyQuery);
            GridView1.DataSource = myDataSet.Tables[0];
            GridView1.DataBind();


        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            String videoID = TextBox2.Text;
            Database myData = new Database();
            string MyQuery2 = "DeleteVideo";



            SqlParameter[] myParameters = new SqlParameter[1];
            myParameters[0] = new SqlParameter("videoID", videoID);

            myData.RunQueryWithParameters(MyQuery2, myParameters);
            fillTable();
            Response.Write("Video Link Deleted");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            String videoLink = TextBox3.Text;
            Database myData = new Database();
            string MyQuery3 = "UpdateVideo";



            SqlParameter[] myParameters = new SqlParameter[1];
            myParameters[0] = new SqlParameter("videoLink", videoLink);

            myData.RunQueryWithParameters(MyQuery3, myParameters);
            fillTable();
            Response.Write("Video Link Update");
        }
    }
}