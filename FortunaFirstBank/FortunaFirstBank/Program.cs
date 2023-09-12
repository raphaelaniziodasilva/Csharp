using System.Globalization;

namespace FortunaFirstBank {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Preencha os dados para criar a conta");
            Console.Write("Nome do titular: ");
            string nome = Console.ReadLine();

            Console.Write("Número da agência: ");
            int agencia = int.Parse(Console.ReadLine());

            Console.Write("Número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            BankAccount conta = new BankAccount(nome, agencia, numero);

            Console.WriteLine("Dados da conta");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Digite o valor a ser depósitado R$: ");
            double valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Depositar(valorDeposito);

            Console.WriteLine("Dados Atualizados");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Digite o valor a ser sacado R$: ");
            double valorSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(valorSaque);

            Console.WriteLine("Dados Atualizados");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.WriteLine("Preencha os dados para criar a conta 2");
            Console.Write("Nome do titular: ");
            string nome1 = Console.ReadLine();

            Console.Write("Número da agência: ");
            int agencia1 = int.Parse(Console.ReadLine());

            Console.Write("Número da conta: ");
            int numero1 = int.Parse(Console.ReadLine());

            BankAccount conta1 = new BankAccount(nome1, agencia1, numero1);

            Console.WriteLine("Dados da conta");
            Console.WriteLine(conta1);

            Console.WriteLine();
            Console.Write("Digite o valor a ser depósitado R$: ");
            double valorDeposito1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta1.Depositar(valorDeposito1);

            Console.WriteLine("Dados Atualizados");
            Console.WriteLine(conta1);

            Console.WriteLine();
            Console.Write("Digite o valor a ser transferido R$: ");
            double valorTransferir = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta1.Transferir(valorTransferir, conta);

            Console.WriteLine("Dados Atualizados");
            Console.WriteLine(conta);
            Console.WriteLine(conta1);

        }
    }
}