using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _484Class1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void tempObj(object sender, EventArgs e)
        {
            String Marry = TextBox1.Text.ToString() + " " + TextBox2.Text.ToString();
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox3.Text = TextBox1.ToString();
        }
    }
}