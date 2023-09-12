using RightBuy.Entities;
using RightBuy.Entities.Enums;
using System.Globalization;

namespace RightBuy {
    internal class Program {
        static void Main(string[] args) {
            // create client
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Date of birth: ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name, email, birthDate);

            // create order
            Console.WriteLine();
            Console.WriteLine("Enter order data");
            DateTime moment = DateTime.Now;

            // insert status of order 
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order order = new Order(moment, status, client);

            Console.WriteLine();
            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++) {
                // creat item
                Console.WriteLine();
                Console.WriteLine($"Enter #{i} item data:");

                // creat product
                Console.Write("Product name: ");
                string nameProduct = Console.ReadLine();

                Console.Write("Product price: ");
                double priceProduct = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product product = new Product(nameProduct, priceProduct);

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                // create OrderItem
                OrderItem orderItem = new OrderItem(quantity, priceProduct, product);

                // adding OrderItem to order items list
                order.AddItem(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine(order);


        }
    }
}