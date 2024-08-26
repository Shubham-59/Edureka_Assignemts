using Assignment4;

namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Admin admin = new Admin();
            Customer customer = new Customer();

            while (true)
            {
                Console.WriteLine("Who are you?");
                Console.WriteLine("1. Admin");
                Console.WriteLine("2. Customer");
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("1. Add product");
                        Console.WriteLine("2. Display products");
                        Console.Write("Enter your choice: ");
                        int adminChoice = int.Parse(Console.ReadLine());

                        if (adminChoice == 1)
                        {
                            Console.Write("Enter product name: ");
                            string pname = Console.ReadLine();
                            Console.Write("Enter quantity in stock: ");
                            int qtyInStock = int.Parse(Console.ReadLine());
                            Console.Write("Enter price: ");
                            decimal price = decimal.Parse(Console.ReadLine());
                            Console.Write("Enter discount allowed: ");
                            decimal discount = decimal.Parse(Console.ReadLine());

                            admin.AddProduct(pname, qtyInStock, price, discount);
                        }
                        else if (adminChoice == 2)
                        {
                            admin.DisplayProducts();
                        }
                        break;

                    case 2:
                        Console.Write("Enter product name to order: ");
                        string pnameToOrder = Console.ReadLine();
                        Console.Write("Enter quantity: ");
                        int quantity = int.Parse(Console.ReadLine());

                        customer.OrderProduct(admin, pnameToOrder, quantity);
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }

                Console.WriteLine("Do you want to continue? (yes/no)");
                string continueChoice = Console.ReadLine().ToLower();
                if (continueChoice != "yes")
                {
                    break;
                }
            }
        }
    }
}
