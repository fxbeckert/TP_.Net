using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebServiceConsumer
{
    public partial class WebFormServiceConsumer : System.Web.UI.Page
    {
        private myWebServiceReference.WebServiceHelloWorld myWS;
        protected void Page_Load(object sender, EventArgs e)
        {
            myWS = new myWebServiceReference.WebServiceHelloWorld();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            this.Label1.Text = myWS.HelloWorld();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            this.Label2.Text = myWS.Hello(this.TextBox1.Text);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            this.Label3.Text = myWS.Add(
                int.Parse(this.TextBox2.Text),
                int.Parse(this.TextBox3.Text))
                .ToString();
        }
    }
}