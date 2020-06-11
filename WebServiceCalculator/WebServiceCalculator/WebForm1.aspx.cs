using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebServiceCalculator
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        private CalculatorReference.Calculator calculatorReference;

        protected void Page_Load(object sender, EventArgs e)
        {
            calculatorReference = new CalculatorReference.Calculator();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            this.Label1.Text = calculatorReference.Add(
                int.Parse(this.TextBox1.Text), 
                int.Parse(this.TextBox2.Text)).ToString();
        }
    }
}