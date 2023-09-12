using System.Globalization;

namespace Funcionarios {
    internal class Program {
        static void Main(string[] args) {
            Funcionario funcionario = new Funcionario();

            Console.WriteLine("Digite os dados do funcionario");
            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();

            Console.Write("Salario Bruto: ");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Imposto: ");
            funcionario.Impostos = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Funcionario: " + funcionario);

            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salario: ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            funcionario.AumentarSalario(porcentagem);

            Console.WriteLine("Dados atualizados: " + funcionario);

        }
    }
}