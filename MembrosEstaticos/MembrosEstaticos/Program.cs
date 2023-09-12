using System.Globalization;

namespace MembrosEstaticos {
    // Vamos fazer um programa para ler o valor de um raio
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Chamando a classe Calculadora diretamente sem precisar instanciar o objeto Calculadora

            // calculando a circunferencia do raio usando a classe Calculadora e o metodo Circunferencia
            double circ = Calculadora.Circunferencia(raio);

            // calculando o volume do raio usando a classe Calculadora e o metodo Voliume
            double volume = Calculadora.Voliume(raio);

            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}