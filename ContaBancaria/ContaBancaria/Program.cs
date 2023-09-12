using System.Globalization;

namespace ContaBancaria {
    internal class Program {
        static void Main(string[] args) {
            ContaB conta;

            Console.Write("Digite o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome do titular: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n) ? ");
            char resposta = char.Parse(Console.ReadLine());

            if(resposta == 's' || resposta == 'S') {
                Console.Write("Digite o valor do depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                // criando a conta com deposito inicial
                conta = new ContaB(numero, titular, depositoInicial);
            } else {
                // criandop a conta sem deposito
                conta = new ContaB(numero, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);

            // fazendo deposito
            Console.WriteLine();
            Console.Write("Digite o valor a ser depositado: ");
            double valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(valorDeposito);

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);

            // fazendo saque
            Console.WriteLine();
            Console.Write("Digite o valor a ser sacado: ");
            double valorsaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(valorsaque);

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);






        }
    }
}