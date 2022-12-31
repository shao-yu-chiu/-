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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

           if(Request.Cookies["UserName"] == null)
            {
                Response.Cookies["UserName"].Value = HttpUtility.UrlEncode("未登入");
            }
            else
            {   
                if(Request.Cookies["UserName_register"] == null)
                {
                    Response.Cookies["UserName_register"].Value = HttpUtility.UrlEncode("未登入");

                }
                if (HttpUtility.UrlDecode(Request.Cookies["UserName_register"].Value) == "未登入")
                {
                    Response.Write("<div style='position:relative;left:50%;transform:translate(-50%); width:500px;border: 3px solid rgb(0, 0, 0); border-radius:6px; text-align:center; '><div style='color: #EE8872;border-radius:6px;'><h1 >請先登入</h1></div></div>");
                }
                    Label1.Text = HttpUtility.UrlDecode(Request.Cookies["UserName_register"].Value); 
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(HttpUtility.UrlDecode(Request.Cookies["UserName_register"].Value) != "未登入" || HttpUtility.UrlDecode(Request.Cookies["UserName_register"].Value) == null)
            {
                Response.Write("<div style='position:relative;left:50%;transform:translate(-50%); width:500px;border: 3px solid rgb(0, 0, 0); border-radius:6px; text-align:center; '><div style='color: #EE8872;border-radius:6px;'><h1 >請勿重複登入</h1></div></div>");
            }
            else
            {
                
                string str = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True";

                string queryString_Select =
                        "SELECT * FROM dbo.userfiles;";

                using (SqlConnection connection =
                           new SqlConnection(str))
                {
                    SqlCommand command =
                        new SqlCommand(queryString_Select, connection);
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();
                    string aa = "";
                    // Call Read before accessing data.
                    while (reader.Read())
                    {

                        IDataRecord dataRecord = (IDataRecord)reader;
                        Console.WriteLine(String.Format("{0}, {1}, {2}, {3}", dataRecord[0], dataRecord[1], dataRecord[2], dataRecord[3]));

                        if(TextBox1.Text == Convert.ToString(dataRecord[1]) && TextBox2.Text == Convert.ToString(dataRecord[2]))
                        {
                            Response.Cookies["UserName_register"].Value = HttpUtility.UrlEncode(Convert.ToString(dataRecord[3]));
                            Response.Redirect("homepage.aspx");
                        }
                        else
                        {
                            
                            Response.Cookies["UserName"].Value = HttpUtility.UrlEncode("訪客模式");
                        
                        }
                        aa += Convert.ToString(dataRecord[1]);
                        Response.Cookies["UserName"].Expires = DateTime.Now.AddHours(3);
                    
                    }
                    Response.Write("<div style='position:relative;left:50%;transform:translate(-50%); width:500px;border: 3px solid rgb(0, 0, 0); border-radius:6px; text-align:center; '><div style='color: #EE8872;border-radius:6px;'><h1 >帳號密碼錯誤</h1></div></div>");
                    //Response.Write(aa);
                    // Call Close when done reading.
                    reader.Close();
                }
                
                }
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("register.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("homepage.aspx");
            Response.Cookies["UserName"].Value = HttpUtility.UrlEncode("訪客模式");
        }
    }


 }
