using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["UserName"] == null)
            {
                Response.Cookies["UserName"].Value = HttpUtility.UrlEncode("未登入");
            }
            else
            {
                if (Request.Cookies["UserName_register"] == null)
                {
                    Response.Cookies["UserName_register"].Value = HttpUtility.UrlEncode("未登入");
                }
                Label1.Text = HttpUtility.UrlDecode(Request.Cookies["UserName_register"].Value);
            }
        }

        public static class ResponseCode
        {
            public static int rscode;
            public static int svcode;
            public static int checkcode;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string str = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True";


            string queryString_Read = "SELECT * FROM dbo.userfiles;";

            using (SqlConnection connection =
                           new SqlConnection(str))
            {
                /////readDB
                SqlCommand command = new SqlCommand(queryString_Read, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                string aa = "";
                ResponseCode.rscode = 0;
                // Call Read before accessing data.
                while (reader.Read())
                {

                    IDataRecord dataRecord = (IDataRecord)reader;
                    Console.WriteLine(String.Format("{0}, {1}, {2}, {3}", dataRecord[0], dataRecord[1], dataRecord[2], dataRecord[3]));

                    if (TextBox1.Text == Convert.ToString(dataRecord[1]))//&& 
                    {
                        Response.Write("<div style='position:relative;left:50%;transform:translate(-50%); width:500px;border: 3px solid rgb(0, 0, 0); border-radius:6px; text-align:center; '><div style='color: #EE8872;border-radius:6px;'><h1 >帳號已被註冊</h1></div></div>");
                        ResponseCode.rscode = 0;
                        break;
                    }
                    if (TextBox3.Text == Convert.ToString(dataRecord[3]))
                    {

                        Response.Write("<div style='position:relative;left:50%;transform:translate(-50%); width:500px;border: 3px solid rgb(0, 0, 0); border-radius:6px; text-align:center; '><div style='color: #EE8872;border-radius:6px;'><h1 >使用者名稱已被註冊</h1></div></div>");
                        ResponseCode.rscode = 0;
                        break;
                    }
                    else
                    {
                        ResponseCode.rscode = 1;

                    }
                    ResponseCode.svcode = Convert.ToInt32(dataRecord[0]) + 1;
                   // Response.Write("使用者名稱已被註冊");
                }
                reader.Close();
                ResponseCode.checkcode = 1;
            }
            using (SqlConnection connection =
               new SqlConnection(str))
            {
                if (ResponseCode.checkcode == 1)
                { 
                    int svrs = ResponseCode.rscode; 
                    if (svrs == 1)
                    {
                        string queryString_Select = "INSERT INTO dbo.userfiles (id,account,passwords, username) VALUES (" + ResponseCode.svcode+",'"+
                                           TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "');";
                    /////insertDB
                        SqlCommand command_I =
                        new SqlCommand(queryString_Select, connection);
                        connection.Open();


                        command_I.ExecuteNonQuery();
                        Response.Redirect("login.aspx");
                }
            }
            }

        }
        protected void Button2_Click1(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }
    }
}