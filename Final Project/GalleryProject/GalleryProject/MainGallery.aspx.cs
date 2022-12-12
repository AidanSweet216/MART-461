using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace GalleryProject
{
    public partial class MainGallery : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Database myData = new Database();

            string MyQuery = "GetVideos";
            DataSet myDataSet = myData.getQueryWithoutParameters(MyQuery);
            //string finalOutput = "<table><tr>";
            if (myDataSet.Tables[0].Rows.Count > 0)
            {
                HtmlGenericControl myTable = new HtmlGenericControl("table");
                HtmlGenericControl myTR = new HtmlGenericControl("tr");
                for (int i = 0; i < myDataSet.Tables[0].Rows.Count; i++) 
                {
                    //Response.Write(i);
                    HtmlGenericControl test = new HtmlGenericControl ("iframe");
          
                    HtmlGenericControl myTD = new HtmlGenericControl("td");
                    if(i%2 == 0)
                    {
                        myTR = new HtmlGenericControl("tr");
                        myTable.Controls.Add(myTR);
                       
                    }
                
                    myTR.Controls.Add(myTD);
                    test.Attributes.Add("src", myDataSet.Tables[0].Rows[i]["VideoLink"].ToString());
                    test.Attributes.Add("height", "480");
                    test.Attributes.Add("width", "720");
                    myTD.Controls.Add(test);
                   
                }
                
                whatever.Controls.Add(myTable);
            }
            
           
           
        }
    }
}