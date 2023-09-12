using Heranca.Entities;
using System.Globalization;

namespace Heranca {
    internal class Program {
        static void Main(string[] args) {
            // esta dando erro na acc1 porque e Account e uma classe abstrata e nao pode ser instanciada
            // Account acc1 = new Account(1001, "Sanji", 500.0);

            // podemos criar uma lista do tipo account
            List<Account> list = new List<Account>();

            // vamos adicionar as subclasses na lista ou seja as classes herdadas
            list.Add(new SavingsAccount(1001, "Kaido", 800.00, 0.01));
            list.Add(new BusinessAccount(1002, "Shanks", 700.00, 400.00));
            list.Add(new SavingsAccount(1003, "Big mom", 600.00, 0.03));
            list.Add(new BusinessAccount(1004, "Barba branca", 500.00, 500.00));

            double sum = 0.0;
            foreach (Account acc in list) {
                sum += acc.Balance;                
            }
            Console.WriteLine($"Total balance R$: {sum.ToString("F2", CultureInfo.InvariantCulture)}");

            // vamos fazer um saque de cada conta
            foreach (Account acc in list) {
                acc.Withdraw(10);
            }

            // imprimindo o saldo atualizado
            foreach (Account acc in list) {
               Console.WriteLine($"Updated balance for account {acc.Number}: {acc.Balance.ToString("F2",
                   CultureInfo.InvariantCulture)}");
            }






        }
    }
}