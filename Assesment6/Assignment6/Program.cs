namespace Assignment6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pizza> list = new List<Pizza>();
            Console.WriteLine();
            Console.WriteLine("*****Welcome to Pizza Hut*****");
            Console.WriteLine();
            string ch;
            do
            {
                Console.WriteLine("Enter Size of Pizza");
                string size = Console.ReadLine().ToLower();

                Console.WriteLine("Enter number of cheese topping");
                int cheese = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter number of pepperoni toppings");
                int pepperoni = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter number of ham topping");
                int ham = int.Parse(Console.ReadLine());

                Pizza pizza = new Pizza(size, cheese, pepperoni, ham);
                list.Add(pizza);
                pizza.GetDescription();
                double cost = pizza.CalcCost(size);
                Console.WriteLine("Cost Of Your Pizza:" + cost);

                Console.WriteLine("Do you want to order more(yes/no)");
                ch = Console.ReadLine().ToLower();
            }
            while (ch == "yes");
            Console.WriteLine();
            Console.WriteLine( "***Thank You! Visit again.***");
            Console.WriteLine();
        }
    }
    
}
