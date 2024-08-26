using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class Product
    {
            public string PName { get; set; }
            public int QtyInStock { get; set; }
            public decimal Price { get; set; }
            public decimal Discount { get; set; }

            public Product(string pname, int qtyInStock, decimal price, decimal discount)
            {
                PName = pname;
                QtyInStock = qtyInStock;
                Price = price;
                Discount = discount;
            }

            public void DisplayDetails()
            {
                Console.WriteLine($" Product name : {PName}");
                Console.WriteLine($" Product quantity available in stock : {QtyInStock}");
                Console.WriteLine($" Product price : Rs.{Price}");
                Console.WriteLine($" Product discount : {Discount}%");
            }
    }
}
