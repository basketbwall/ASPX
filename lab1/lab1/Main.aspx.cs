using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab1
{
    public partial class Main : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) //If viewing this page for the "first" time then it doesn't load the text yet
            {
                //if conditions for the ingredients checkboxes
                List<String> ingredientsList = new List<String>();
                if (Request["ingredient1"] != null)
                {
                    ingredientsList.Add(Request["ingredient1"]);
                }
                if (Request["ingredient2"] != null)
                {
                    ingredientsList.Add(Request["ingredient2"]);

                }
                if (Request["ingredient3"] != null)
                {
                    ingredientsList.Add(Request["ingredient3"]);

                }
                if (Request["ingredient4"] != null)
                {
                    ingredientsList.Add(Request["ingredient4"]);

                }
                if (Request["ingredient5"] != null)
                {
                    ingredientsList.Add(Request["ingredient5"]);

                }
                //if conditions for the extras checkboxes
                List<String> extrasList = new List<String>();
                if (Request["extra1"] != null)
                {
                    extrasList.Add(Request["extra1"]);
                }
                if (Request["extra2"] != null)
                {
                    extrasList.Add(Request["extra2"]);

                }
                if (Request["extra3"] != null)
                {
                    extrasList.Add(Request["extra3"]);

                }
                if (Request["extra4"] != null)
                {
                    extrasList.Add(Request["extra4"]);

                }
                if (Request["extra5"] != null)
                {
                    extrasList.Add(Request["extra5"]);

                }
                sandwich customerSandwich = new sandwich(Request["lstbSize"], Request["toasted"], Request["spread"], extrasList, ingredientsList, Request["meal"], Convert.ToDecimal(Request["txtTip"]), .06m);
                
                

                String name = Request["txtName"]; //use request object and call on the name
                string phoneNumber = Request["txtPhoneNumber"];
                phoneNumber = phoneNumber.Replace("-", "");
                bool wrongNumber = false;
                for(int i=0; i<phoneNumber.Length; i++)
                {
                    if (48 > phoneNumber[i] || phoneNumber[i] > 57)
                    {
                        wrongNumber = true;
                    }
                }
                if (phoneNumber.Length != 10)
                {
                    //tell user the phone number entered was invalid. Try filling out the form once again.
                    pTagText.InnerHtml = "The phone number entered was invalid. Try filling out the form once again.";
                } else if (wrongNumber)
                {
                    pTagText.InnerHtml = "The phone number has non-integers. Please re-enter your phone number.";
                }
                else
                {
                    customer ourCustomer = new customer(name, phoneNumber);
                    string output = "";
                    output += "Your name is: " + ourCustomer.Name + "<br />"; //don't use \n use the break html tag instead
                    output += ("Your phone number is: " + ourCustomer.phoneNumber + "<br />");
                    output += ("You chose sandwich size: " + customerSandwich.Size + " $" + customerSandwich.getItemPrice(Convert.ToString(customerSandwich.Size)) + "<br /> ");
                    output += ("Toasted?: " + customerSandwich.Toasted + " $" + customerSandwich.getItemPrice(Convert.ToString(customerSandwich.Toasted)) + "<br /> ");
                    output += ("Spread: " + customerSandwich.Spread + " $" + customerSandwich.getItemPrice(Convert.ToString(customerSandwich.Spread)) + "<br />");
                    output += "Ingredients you chose: <br />" + customerSandwich.getIngredients();
                    output += "Extras you chose: <br />" + customerSandwich.getExtras();
                    output += ("Meal: " + customerSandwich.MealType + " $" + customerSandwich.getItemPrice(Convert.ToString(customerSandwich.MealType)) + "<br /> ");
                    output += ("Tax Amount: $" + customerSandwich.getTaxPaid() + "<br /> ");
                    output += ("Tip Amount: $" + customerSandwich.Tip + "<br />");
                    output += ("Total with tax and tip applied: $" + customerSandwich.calculateCost());
                    //lblOutput.Text = output; no longer wish to take this route. instead Gonna modify the paragraph tag
                    pTagText.InnerHtml = output;
                }

            }


        }
    }
}