using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ServiceReference2.WebService1SoapClient cl = new ServiceReference2.WebService1SoapClient();
            Label1.Text = cl.Add(Convert.ToInt32(TextBox1.Text), Convert.ToInt32(TextBox2.Text)).ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ServiceReference2.WebService1SoapClient cl = new ServiceReference2.WebService1SoapClient();
            Label2.Text = cl.Add1(Convert.ToInt32(TextBox1.Text), Convert.ToInt32(TextBox2.Text)).ToString();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            ServiceReference2.WebService1SoapClient cl = new ServiceReference2.WebService1SoapClient();
            Label3.Text = cl.Add2(Convert.ToInt32(TextBox1.Text), Convert.ToInt32(TextBox2.Text)).ToString();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            ServiceReference2.WebService1SoapClient cl = new ServiceReference2.WebService1SoapClient();
            Label4.Text = cl.Add3(Convert.ToInt32(TextBox1.Text), Convert.ToInt32(TextBox2.Text)).ToString();
        }
    }
}