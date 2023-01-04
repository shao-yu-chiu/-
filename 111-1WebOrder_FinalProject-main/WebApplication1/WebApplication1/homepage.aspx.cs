using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class homepage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["UserName"] == null)
            {
                Response.Cookies["UserName"].Value = HttpUtility.UrlEncode("訪客模式");
            }
            else
            {
                if (Request.Cookies["UserName_register"] == null)
                {
                    Response.Cookies["UserName_register"].Value = HttpUtility.UrlEncode("訪客模式");
                }
                Label1.Text = HttpUtility.UrlDecode(Request.Cookies["UserName_register"].Value);
            }
            if(TextBox1.Text == "") TextBox1.Text = "1";
            if(TextBox2.Text == "") TextBox2.Text = "1";
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (HttpUtility.UrlDecode(Request.Cookies["UserName_register"].Value) == "訪客模式")
            {
                Response.Cookies["login_check"].Value = "0";
                Response.Redirect("login.aspx");
            }
            else
            {
                Response.Cookies["Orders"].Value = "";
                Response.Cookies["Orders"].Value = HttpUtility.UrlEncode(TextBox3.Text);
                TextBox3.Text = "";
                Response.Redirect("result.aspx");
            }
        }
        public static class total_food
        {
            public static string food;
            
        }
        public static class total_drink
        {
            public static string drink;
        }
        public static class total_money
        {
            public static int money;
        }
        public static class total_method
        {
            public static string method;
        }
        public int count_food_money()
        {

            int money = 0;
            if (DropDownList1.SelectedItem.Text == "砂鍋獅子頭") money += (380*Convert.ToInt32(TextBox1.Text));
            if (DropDownList1.SelectedItem.Text == "豆瓣黃魚") money += (720 * Convert.ToInt32(TextBox1.Text));
            if (DropDownList1.SelectedItem.Text == "腰果蝦仁") money += (380 * Convert.ToInt32(TextBox1.Text));
            if (DropDownList1.SelectedItem.Text == "桔汁牛小排") money += (460 * Convert.ToInt32(TextBox1.Text));
            if (DropDownList1.SelectedItem.Text == "五更腸旺") money += (320 * Convert.ToInt32(TextBox1.Text));
            return money;
        }
        public int count_drink_money()
        {

            int money = 0;
            if (DropDownList2.SelectedItem.Text == "紅茶") money += (30 * Convert.ToInt32(TextBox2.Text));
            if (DropDownList2.SelectedItem.Text == "綠茶") money += (30 * Convert.ToInt32(TextBox2.Text));
            if (DropDownList2.SelectedItem.Text == "奶茶") money += (40 * Convert.ToInt32(TextBox2.Text));
            if (DropDownList2.SelectedItem.Text == "冬瓜檸檬") money += (45 * Convert.ToInt32(TextBox2.Text));
            if (DropDownList2.SelectedItem.Text == "水果茶") money += (55 * Convert.ToInt32(TextBox2.Text));
            return money;
        }
        public string count_food()
        {
            string food_name = "";

            if (DropDownList1.SelectedItem.Text == "砂鍋獅子頭") food_name += (DropDownList1.SelectedItem.Text+" 數量: " +
                    TextBox1.Text +"\n");
            if (DropDownList1.SelectedItem.Text == "豆瓣黃魚") food_name += (DropDownList1.SelectedItem.Text + "\t數量: " +
                    TextBox1.Text + "\n");
            if (DropDownList1.SelectedItem.Text == "腰果蝦仁") food_name += (DropDownList1.SelectedItem.Text + "\t數量: " +
                    TextBox1.Text + "\n");
            if (DropDownList1.SelectedItem.Text == "桔汁牛小排") food_name += (DropDownList1.SelectedItem.Text + "\t數量: " +
                    TextBox1.Text + "\n");
            if (DropDownList1.SelectedItem.Text == "五更腸旺") food_name += (DropDownList1.SelectedItem.Text + "\t數量: " +
                    TextBox1.Text + "\n");

            return food_name;
        }
        public string count_drink()
        {
            string drink_name = "";

            if (DropDownList2.SelectedItem.Text == "紅茶") drink_name += (DropDownList2.SelectedItem.Text + "\t數量: " +
                    TextBox2.Text + "\n");
            if (DropDownList2.SelectedItem.Text == "綠茶") drink_name += (DropDownList2.SelectedItem.Text + "\t數量: " +
                    TextBox2.Text + "\n");
            if (DropDownList2.SelectedItem.Text == "奶茶") drink_name += (DropDownList2.SelectedItem.Text + "\t數量: " +
                    TextBox2.Text + "\n");
            if (DropDownList2.SelectedItem.Text == "冬瓜檸檬") drink_name += (DropDownList2.SelectedItem.Text + "\t數量: " +
                    TextBox2.Text + "\n");
            if (DropDownList2.SelectedItem.Text == "水果茶") drink_name += (DropDownList2.SelectedItem.Text + "\t數量: " +
                    TextBox2.Text + "\n");

            return drink_name;
        }

        public string send_order()
        {
            string method = "";
            if (RadioButton1.Checked) method = RadioButton1.Text;
            if (RadioButton2.Checked) method = RadioButton2.Text;
            if (RadioButton3.Checked) method = RadioButton3.Text;
            return method;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (total_money.money >= 1000) {
                Random random = new Random();
                int price=random.Next(1, 10);
                Response.Cookies["price"].Value = HttpUtility.UrlEncode(Convert.ToString(price));
            }
            total_food.food += count_food(); total_money.money += count_food_money();
            TextBox3.Text = "食物:\n" + total_food.food + "飲料:\n" + total_drink.drink + "總金額:\n" + total_money.money +"\n取餐方式: "+ total_method.method;
            
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            total_drink.drink += count_drink(); total_money.money += count_drink_money();
            TextBox3.Text = "食物:\n" + total_food.food + "飲料:\n" + total_drink.drink + "總金額:\n" + total_money.money + "\n取餐方式: " + total_method.method;
        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            total_method.method = send_order();
            TextBox3.Text = "食物:\n" + total_food.food + "飲料:\n" + total_drink.drink + "總金額:\n" + total_money.money + "\n取餐方式: " + total_method.method;
        }

        protected void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            total_method.method = send_order();
            TextBox3.Text = "食物:\n" + total_food.food + "飲料:\n" + total_drink.drink + "總金額:\n" + total_money.money + "\n取餐方式: " + total_method.method;
            
        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            total_method.method = send_order();
            TextBox3.Text = "食物:\n" + total_food.food + "飲料:\n" + total_drink.drink + "總金額:\n" + total_money.money +"\n取餐方式: "+ total_method.method;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Cookies["UserName_register"].Value = HttpUtility.UrlEncode("未登入");
            Response.Cookies["UserName"].Value = null;
                HttpUtility.UrlEncode("未登入");
            Response.Redirect("login.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            total_food.food = "";
            total_drink.drink = "";
            total_money.money = 0;
            total_method.method="";
            TextBox3.Text = "";
        }
    }
}