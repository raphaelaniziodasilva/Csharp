using System.Globalization;

namespace Fintech.Entities {
    internal class Investments {
        public string Name { get; set; }
        public double Value { get; set; }
        public int Percentage { get; set; }
        public DateTime InvestimentDate { get; set; }
        public double Profits { get; set; }

        public Investments(string name, double value, int percentage, DateTime investimentDate) {
            Name = name;
            Value = value;
            Percentage = percentage;
            InvestimentDate = investimentDate;
        }

        public double InvestmentProfits() {
            return Profits = Value * (Percentage / 100.0);
        }

        public override string ToString() {
            return "Investment Information:\n" +
                "Name: " + Name + "\n" +
                "Value R$: " + Value.ToString("F2", CultureInfo.InvariantCulture) + "\n" +
                "Percentage: " + Percentage + "%\n" +
                "Investment Date: " + InvestimentDate + "\n" +
                "Profits R$: " + Profits.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
