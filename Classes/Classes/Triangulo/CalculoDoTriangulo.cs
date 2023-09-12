using Classes.Triangulo;
using System.Globalization;

internal class CalculoDoTriangulo {
    private static void Main(string[] args) {
        // criando as variavel x e y e tipando com a classe triangulo
        Triangulo x, y;

        // instanciando a classe triangulo
        x = new Triangulo();
        y = new Triangulo();

        // interagindo com o usuario
        Console.WriteLine("Digite as medidas do triângulo X: ");
        x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Digite as medidas do triângulo Y: ");
        y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        // chamando o metodo Area para calcular a area de x e y
        double areaX = x.Area();       
        double areay = y.Area();

        Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
        Console.WriteLine("Área de Y = " + areay.ToString("F4", CultureInfo.InvariantCulture));

        // verificando se a areax e maior que a areay
        if(areaX > areay) {
            Console.WriteLine("triângulo X e maior que triângulo Y");
        } else {
            Console.WriteLine("triângulo Y e maior que triângulo X");
        }
    } 
}