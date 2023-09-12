
using System.Globalization;
using System.Xml.Linq;

namespace Fintech.Entities {
    internal class Wallet {
        public string Name { get; set; }
        public double Balance { get; set; }
        public double Spending { get; set; }

        public Wallet(string name, double balance) {
            Name = name;
            Balance = balance;
        }

        public void Deposit(double value) {
            if (value > 0) {
                Balance += value;
            }
            else {
                throw new ArgumentException("Value must be greater than zero.");
            }
        }

        public void Withdraw(double value) {
            if (value > 0 && value <= Balance) {
                Balance -= value;
            }
            else {
                throw new ArgumentException("Invalid withdrawal amount or insufficient balance.");
            }
        }

        public double SpendingOfTheMonth(String description, double value) {
            return Spending += value;
        }

        public double SavingsOfTheMonth() {
            double economy;
            return economy = Balance - Spending;
        }

        public override string ToString() {
            return "Wallet Information:\n" +
                    "Name: " + Name + "\n" +
                    "Balance R$: " + Balance.ToString("F2", CultureInfo.InvariantCulture) + "\n" +
                    "Spending R$: " + Spending.ToString("F2", CultureInfo.InvariantCulture) + "\n" +
                    "Savings of the Month R$: " + SavingsOfTheMonth().ToString("F2", CultureInfo.InvariantCulture);
        }
    }

}
