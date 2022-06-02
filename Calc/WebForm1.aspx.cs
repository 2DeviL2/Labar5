using Lab_5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Calc
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.WebService1SoapClient c1 = new ServiceReference1.WebService1SoapClient();

            try
            {
                Label1.Text = c1.Plus(Convert.ToDouble(TextBox1.Text), Convert.ToDouble(TextBox2.Text)).ToString();
            }
            catch (FormatException)
            {
                Label1.Text = "Вводите числа!!!";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ServiceReference1.WebService1SoapClient c1 = new ServiceReference1.WebService1SoapClient();
            try
            {
                Label1.Text = c1.Minus(Convert.ToDouble(TextBox1.Text), Convert.ToDouble(TextBox2.Text)).ToString();
            }
            catch (FormatException)
            {
                Label1.Text = "Вводите числа!!!";
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            ServiceReference1.WebService1SoapClient c1 = new ServiceReference1.WebService1SoapClient();
            try
            {
                Label1.Text = c1.Multi(Convert.ToDouble(TextBox1.Text), Convert.ToDouble(TextBox2.Text)).ToString();
            }
            catch (FormatException)
            {
                Label1.Text = "Вводите числа!!!";
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            ServiceReference1.WebService1SoapClient c1 = new ServiceReference1.WebService1SoapClient();
            try
            {
                Label1.Text = c1.Division(Convert.ToDouble(TextBox1.Text), Convert.ToDouble(TextBox2.Text)).ToString();
            }
            catch (FormatException)
            {
                Label1.Text = "Вводите числа!!!";

            }
        }

        protected void Button5_Click1(object sender, EventArgs e)
        {
            WebService1 ws = new WebService1();
            GridView1.DataSource = ws.GetCustomers();
            GridView1.DataBind();
        }
    }
}