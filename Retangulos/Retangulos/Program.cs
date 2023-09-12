using System.Globalization;

namespace Retangulos {
    internal class Program {
        static void Main(string[] args) {
            Retangulo retangulo = new Retangulo();

            Console.WriteLine("Digite os dados do retângulo");
            Console.Write("Largura: ");
            retangulo.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite os dados do retângulo");
            Console.Write("Altura: ");
            retangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do retangulo " + retangulo);

            Console.WriteLine("Area do retangulo " + retangulo.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perimetro do retangulo " + retangulo.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal do retangulo " + retangulo.Diagonal().ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}