namespace HerancaExResolvido.Entities {
    internal class Employee {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }

        public Employee(string name, int hours, double valuePerHour) {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        // incluindo a palavra virtual para poder sobreescrever esse metodo na classe filha ou seja na classe herdada
        public virtual double Payment() {
            return Hours * ValuePerHour;
        }
    }
}
