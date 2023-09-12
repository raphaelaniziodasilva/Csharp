using System.Globalization;
using System.Xml.Linq;

namespace RightBuy.Entities {
    internal class OrderItem {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem(int quantity, double price, Product product) {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double SubTotal() {
            return Price * Quantity;
        }

        public override string ToString() {
            return $"{Product.Name}, R${Product.Price.ToString("F2", CultureInfo.InvariantCulture)}, " +
                $"Quantity: {Quantity}, SubTotal R$: {SubTotal().ToString("F2", CultureInfo.InvariantCulture)}  ";
        }
    }
}
