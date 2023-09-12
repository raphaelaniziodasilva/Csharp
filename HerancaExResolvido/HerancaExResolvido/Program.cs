using HerancaExResolvido.Entities;
using System.Globalization;

namespace HerancaExResolvido {
    internal class Program {
        static void Main(string[] args) {
            // criando a lista de funcionaios aonde vai ter tanto funcionario normal como terceirizados
            List<Employee> list = new List<Employee>();

            // usuario vai decidir quantos funcionarios ele vai adicionar
            Console.Write("Enter the number of employees: ");
            int numero = int.Parse(Console.ReadLine());

            // agora vamos percorrer pelo numero de funcionario que o usuario digitou para fazer a leitura dos dados do funcionario
            for(int i = 1; i <= numero; i++) {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (y/n)? ");
                char res = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double valuePerHours = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                // se o funcionario ele for terceirizado: Outsourced
                if (res == 'y' || res == 'Y') {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    // vamos adicionar o funcionario terceirizado na lista
                    list.Add(new OutsourcedEmployee(name, hours, valuePerHours, additionalCharge));
                } else {
                    // addicionando o funcionario normal na lista
                    list.Add(new Employee(name, hours, valuePerHours));
                }

                // imprimindo os dados dos funcionarios
                Console.WriteLine();
                Console.WriteLine("PAYMENTS:");

                // agora vamos percorrer a lista e impromir os dados do funcionarios
                foreach(Employee emp in list) {
                    Console.WriteLine($"{emp.Name} - R${emp.Payment().ToString("F2", CultureInfo.InvariantCulture)}");
                }
            }

        }
    }
}