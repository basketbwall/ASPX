using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lab1
{
    public class sandwich
    {
        public Dictionary<String, decimal> prices { get; set; }

        public string Size { get; set; }
        public String Toasted { get; set; }
        public decimal Tip { get; set; }
        public string Spread { get; set; }

        public List<String> Extras { get; set; }
        public string MealType { get; set; }
        public decimal TaxRate { get; set; }

        public List<String> Ingredients { get; set; }

        public sandwich(string size, string toasted, string spread, List<String> extras, List<String> ingredients, string mealtype, decimal tip, decimal taxrate)
        {
            prices = new Dictionary<String, decimal>();
            //set the prices. If a dev needs to change the price it happens here and the rest of the program will calculate the proper values by accessing the dictionary
            prices["Small"] = 1.00m;
            prices["Medium"] = 2.00m;
            prices["Large"] = 3.00m;
            prices["Toasted"] = .50m; //true for toasted
            prices["Not Toasted"] = .00m; // false for toasted
            prices["Mayo"] = 1.00m;
            prices["Mustard"] = .75m;
            prices["Avocado Ranch"] = 1.50m;
            prices["Pesto"] = 1.00m;
            prices["Jam"] = 2.00m;
            prices["Bacon"] = 3.00m;
            prices["Cheese"] = 5.00m;
            prices["Meat"] = 6.00m;
            prices["Salt"] = 50.00m;
            prices["Spread"] = 100.00m;
            prices["Lettuce"] = 3.00m;
            prices["Tomato"] = 5.00m;
            prices["Onion"] = 6.00m;
            prices["Egg"] = 50.00m;
            prices["Mystery"] = 100.00m;
            prices["Just the sandwich"] = 0.00m;
            prices["Meal with chips"] = 12.50m;
            prices["Meal with fruit"] = 10.00m;
            prices["Meal with cookie"] = 15.50m;
            prices["Meal with chicken nuggets"] = 50.00m;


            this.Size = size;
            this.Toasted = toasted;
            this.Tip = tip;
            this.Spread = spread;

            Extras = new List<String>();
            for (int i=0; i<extras.Count; i++)
            {
                this.Extras.Add(extras[i]);
            }
            Ingredients = new List<String>();
            for (int i = 0; i < ingredients.Count; i++)
            {
                this.Ingredients.Add(ingredients[i]);
            }
            this.MealType = mealtype;
            this.TaxRate = taxrate;

        }


        public decimal calculateCost()
        {
            decimal Total = 0;
            //do stuff to calculate the price
            //calculate the total cost
            Total += prices[Size];
            Total += prices[Convert.ToString(Toasted)];
            Total += prices[Spread];
            for(int i=0; i<Extras.Count; i++)
            {
                string currentExtra = Extras[i];
                Total += prices[currentExtra];
            }
            for (int i = 0; i < Ingredients.Count; i++)
            {
                string currentIngredient = Ingredients[i];
                Total += prices[currentIngredient];
            }
            Total += prices[MealType];
            //add tax
            decimal TaxPrice = Total * TaxRate;
            Total += TaxPrice;
            Total += Tip;
            return Math.Round(Total, 2);
        }

        public decimal getItemPrice(string itemName)
        {
            return this.prices[itemName];
        }

        public string getExtras()
        {
            String output = "";
            for (int i = 0; i < Extras.Count; i++)
            {
                string currentExtra = Extras[i];
                output += currentExtra + " $" + this.prices[currentExtra] + "<br />";
            }
            return output;
        }

        public string getIngredients()
        {
            String output = "";
            for (int i = 0; i < Ingredients.Count; i++)
            {
                string currentIngredient = Ingredients[i];
                output += currentIngredient + " $" + this.prices[currentIngredient] + "<br />";
            }
            return output;
        }

        public decimal getTaxPaid()
        {
            decimal Total = 0;
            //do stuff to calculate the price
            //calculate the total cost
            Total += prices[Size];
            Total += prices[Convert.ToString(Toasted)];
            Total += prices[Spread];
            for (int i = 0; i < Extras.Count; i++)
            {
                string currentExtra = Extras[i];
                Total += prices[currentExtra];
            }
            for (int i = 0; i < Ingredients.Count; i++)
            {
                string currentIngredient = Ingredients[i];
                Total += prices[currentIngredient];
            }
            Total += prices[MealType];
            //add tax
            decimal TaxPrice = Total * TaxRate;
            return Math.Round(TaxPrice, 2);
        }
    }
}