using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class Customer
    {
        public void OrderProduct(Admin admin, string pname, int quantity)
        {
            var product = admin.FindProductByName(pname);
            if (product == null)
            {
                Console.WriteLine("Product not found.");
                return;
            }

            if (product.QtyInStock < quantity)
            {
                Console.WriteLine("Insufficient stock.");
                return;
            }

            decimal totalAmount = product.Price * quantity;
            decimal discount = totalAmount * 0.50M;
            decimal amountToPay = totalAmount - discount;

            product.QtyInStock -= quantity;

            Console.WriteLine($"Order placed successfully for {quantity} units of {pname}.");
            ProduceBill(product, quantity, totalAmount, discount, amountToPay);
        }

        private void ProduceBill(Product product, int quantity, decimal totalAmount, decimal discount, decimal amountToPay)
        {
            Console.WriteLine("Bill Receipt");
            Console.WriteLine($"Product: {product.PName}");
            Console.WriteLine($"Quantity: {quantity}");
            Console.WriteLine($"Total Amount: Rs.{totalAmount}");
            Console.WriteLine($"Discount: {discount}%");
            Console.WriteLine($"Amount to Pay: Rs.{amountToPay}");
        }
    }
}
