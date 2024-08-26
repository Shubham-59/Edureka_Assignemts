using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class Admin
    {
        private List<Product> products = new List<Product>();

        public void AddProduct(string pname, int qtyInStock, decimal price, decimal discountAllowed)
        {
            var product = new Product(pname, qtyInStock, price, discountAllowed);
            products.Add(product);
            Console.WriteLine("Product added successfully.");
        }

        public void DisplayProducts()
        {
            foreach (var product in products)
            {
                product.DisplayDetails();
                Console.WriteLine();
            }
        }

        public Product FindProductByName(string pname)
        {
            return products.Find(p => p.PName.Equals(pname, StringComparison.OrdinalIgnoreCase));
        }
    }
}
