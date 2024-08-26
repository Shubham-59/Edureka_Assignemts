using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    internal class Pizza
    {
        private string pizzaSize { get; set; }
        private int noOfCheeseToppings { get; set; }
        private int noOfPepperoniToppings { get; set; }
        private int noOfHamToppings {  get; set; }

        public Pizza(string size, int cheese, int pepperoni, int ham)
        {
            pizzaSize = size;
            noOfCheeseToppings = cheese;
            noOfPepperoniToppings = pepperoni;
            noOfHamToppings = ham;
        }
        public double CalcCost(String size)
        {
            double Cost=0;

            switch (pizzaSize)
            {
                case "small":
                    Cost = 10;
                    break;

                case "medium":
                    Cost = 12;
                    break;

                case "large":
                    Cost = 14;
                    break;

                default:
                    Console.WriteLine("Invalid pizza size");
                    break;
            }

            double totalCost = Cost + 2 * (noOfCheeseToppings + noOfPepperoniToppings + noOfHamToppings);
            return totalCost;
        }

        public void GetDescription()
        {
            Console.WriteLine($"Size of the Pizza : {pizzaSize}");
            Console.WriteLine($"Number of Cheese Toppings : {noOfCheeseToppings}");
            Console.WriteLine($"Number of Pepperoni Toppings : {noOfPepperoniToppings}");
            Console.WriteLine($"Number of Ham Toppings : {noOfHamToppings}");
        }
    }
}
