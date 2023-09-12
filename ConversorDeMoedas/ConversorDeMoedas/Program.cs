using System.Globalization;

namespace ConversorDeMoedas {   
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Qual e a cotaçao do dolár ?");
            double valorDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Quantos dolár você vai comprar ?");
            double dolarQuantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double result = Conversao.ConverterDolarEmReal(dolarQuantidade, valorDolar);

            Console.WriteLine("Valor a ser pago em reais R$: " + result.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}