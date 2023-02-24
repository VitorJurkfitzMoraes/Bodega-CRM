using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Proj2302.Entities;
using Proj2302.Entities.Enums;


namespace Proj2302

{
    internal class Program
    {
        private static void Main(string[] args)
        {

            /* Client data input */

            Console.WriteLine("Enter client data:");

            Console.Write("Name: ");
            string clientName = Console.ReadLine();

            Console.Write("Email: ");
            string clientEmail = Console.ReadLine();

            Console.Write("Birth date (DD/MM/YYYY): ");
            string clientBirthDate = Console.ReadLine();

            /* Create client */

            Client client = new Client(clientName, clientEmail, clientBirthDate);



            /* Order data input */

            Console.WriteLine("Enter order data:");

            Console.Write("Status: ");
            OrderStatus orderStatus = Enum.Parse<OrderStatus>(Console.ReadLine());

            Console.Write("How many items to this order: ");
            int orderNItems = int.Parse(Console.ReadLine());

            /* Create order */

            Order order = new Order(client, orderStatus);



            /* Loop to add items to order */
            for (int i = 0;i < orderNItems; i++)
            {

                int iNum = i + 1;

                Console.WriteLine("Enter #{0} item data:", iNum);

                Console.Write("Product name: ");
                string productName = Console.ReadLine();

                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Quantity: ");
                int productQuantity = int.Parse(Console.ReadLine());

                Product product = new Product(productName, productPrice);
                OrderItem orderItem = new OrderItem(productQuantity, product);

                order.AddItem(item: orderItem);

            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);
        }
    }

}