using Enumeracoes.Entities.Enums;
using System;


namespace Enumeracoes.Entities {
    internal class Order {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        // status will be of type enum Order Status that contains the status of the order
        public OrderStatus Status { get; set; }

        public override string ToString() {
            return Id + ", "
                + Moment + ", "
                + Status;

        }
    }
}
