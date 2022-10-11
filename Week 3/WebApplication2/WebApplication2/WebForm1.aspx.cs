﻿using System;
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
            string MyQuery = "SELECT * FROM Users";
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
            string myConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlConnection myConnection = new SqlConnection(myConnectionString);
            myConnection.Open();
            string MyQuery = "INSERT  INTO Users(userName,pwd) Values('" + userName+ "','"+password+"')";
            Response.Write(MyQuery);
            SqlCommand myCommand = new SqlCommand(MyQuery);
            myCommand.Connection = myConnection;
            myCommand.CommandType = CommandType.Text;
            myCommand.ExecuteNonQuery();
            //HttpCookie userInfo = new HttpCookie("userInfo" + userName);
            //Response.Cookies.Add(userInfo);
            //Session.Add("secret", password);
             Response.Redirect("WebForm3.aspx?userName="+userName);

        }
    }
}