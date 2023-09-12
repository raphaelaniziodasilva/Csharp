using Fintech.Entities;

namespace Fintech {
    internal class Program {
        static void Main(string[] args) {
            // creating address
            Address lawAddress = new Address(12345, "R Brigadeiro tobias", 333, "Apt 301", "Luz",
                    "Cityville", "SP", "Brasil");

            // create person
            PhysicalPerson law = new PhysicalPerson("Law", "Trafalgar", "10/11/1994", "law@example.com",
                    "1234567890", "987654321", lawAddress, "123456789", "12345678901");

            Address jokerAddress = new Address(44395, "Av Bandeirantes", 505, "Loja", "Luz",
                "Sao paulo", "SP", "Brasil");

            LegalPerson joker = new LegalPerson("Joker", "Cordas", "03/02/1984", "joke@example.com",
                    "11934559400", "1133295966", jokerAddress, "22305400440");

            // create lis
            List<User> users = new List<User>();
            users.Add(law);
            users.Add(joker);

            foreach (User user in users) {
                Console.WriteLine(user);
                Console.WriteLine("--------------------");
            }

            Console.WriteLine("Wallet");
            // create wallet
            Wallet wallet = new Wallet("Joker", 2500.00);
            wallet.Deposit(500.0);
            wallet.Withdraw(200.0);
            wallet.SpendingOfTheMonth("Groceries", 1000.0);

            Console.WriteLine(wallet);
            Console.WriteLine("--------------------");

            Console.WriteLine("Investments");
            // create Investments
            Investments nubank = new Investments("Nubank", 1000.0, 5, new DateTime());
            nubank.InvestmentProfits();
            Investments bitCoins = new Investments("BitCoins", 1500.0, 15, new DateTime());
            bitCoins.InvestmentProfits();

            List<Investments> investments = new List<Investments>();
            investments.Add(nubank);
            investments.Add(bitCoins);

            foreach (Investments invest in investments) {
                Console.WriteLine(invest);
                Console.WriteLine("--------------------");
            }
        }
    }
}