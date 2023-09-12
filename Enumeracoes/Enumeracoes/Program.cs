using Enumeracoes.Entities;
using Enumeracoes.Entities.Enums;

namespace Enumeracoes {
    internal class Program {
        static void Main(string[] args) {
            // create order
            Order order = new Order {
                Id = 1,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            // string to enumeration conversion
            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);

            // enumeration to string conversion
            OrderStatus deliver = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(deliver);

        }
    }
}