namespace HerancaExResolvido.Entities {
    internal class OutsourcedEmployee : Employee {
        public double AdditionalCharge { get; set; }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge)
            : base(name, hours, valuePerHour) {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment() {
            // o base vai reaproveitar toda a logica do metodo Payment da classe pai e vamos acrecentar algumas coisas a mais
            return base.Payment() + 1.1 * AdditionalCharge;
        }
    }
}
