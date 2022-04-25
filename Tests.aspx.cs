using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _484Class1
{
    public partial class Tests : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void bttnAddOrder_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Session["Specified"] = "";
            try
            {
                
                int bef = Convert.ToInt32(checkpep.SelectedValue);
                string current = Session["Specified"].ToString();
                Session["toppings"] = bef;
                Session["Specified"] = " Pepperoni";
            }
            catch
            {

            }
            try
            {
                int bef = Convert.ToInt32(checkbef.SelectedValue);
                Session["toppings"] = bef;
                string comp = Session["Specified"].ToString();
                string current = Session["Specified"].ToString();
                Session["Specified"] = current + " Beef";
            }
            catch
            {

            }
            try
            {
                int comp = Convert.ToInt32(Session["toppings"]);
                string current = Session["Specified"].ToString();
                int bef = Convert.ToInt32(checkpepp.SelectedValue);
                Session["toppings"] = bef + comp;
                Session["Specified"] = current + " Peppers";
            }
            catch
            {

            }
            try
            {
                int comp = Convert.ToInt32(Session["toppings"]);
                int bef = Convert.ToInt32(checkon.SelectedValue);
                string current = Session["Specified"].ToString();
                Session["toppings"] = bef + comp;
                Session["Specified"] = current + " Onions ";
            }
            catch
            {

            }
            try
            {
                int comp = Convert.ToInt32(Session["toppings"]);
                int bef = Convert.ToInt32(checkpin.SelectedValue);
                string current = Session["Specified"].ToString();
                Session["toppings"] = bef + comp;
                Session["Specified"] = current + " Pineapple";
            }
            catch
            {

            }

            int value = (Convert.ToInt32(Radiobttn.SelectedValue));

            if (value== 7)
            {
                Session["Size"] = "small";
            }
            else if (value == 9)
            {
                Session["Size"] = "medium";
            }
            else if (value == 11)
            {
                Session["Size"] = "large";
            }
            else if (value == 18)
            {
                Session["Size"] = "X-large";
            }



            String CurrentOrder = Ordertxt.Text;
            int total = (Convert.ToInt32(Radiobttn.SelectedValue) + Convert.ToInt32(Session["toppings"]) * Convert.ToInt32(DropDown.SelectedValue));

            Ordertxt.Text = CurrentOrder+ System.Environment.NewLine+  DropDown.Text+ Session["Size"].ToString() + " " + " pizza(s) with"  + Session["Specified"]+  " " + "costing $" + total.ToString() + " "+"for " +CustName.Text.ToString();
        }
    }
}