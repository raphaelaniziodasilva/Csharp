using System.Globalization;

namespace ExercicioC_ {
    internal class Exercicios {
        private static void Main(string[] args) {

            Console.WriteLine("Exercicio 1");
            // execute uma interaçao com o usuario, lendo os valores, e depois imprimir na tela
            // nome: Ace, idade: 23, recompensa: R$:3300200.80 nomePirata: Punho de fogo

            string nome = Console.ReadLine();
            int idade = int.Parse(Console.ReadLine());
            double recompensa = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            string nomePirata = Console.ReadLine();

            Console.WriteLine(nome);
            Console.WriteLine(idade);
            Console.WriteLine(recompensa.ToString("F5"), CultureInfo.InvariantCulture);
            Console.WriteLine(nomePirata);

            Console.WriteLine("Exercicio 2");
            // execute uma interaçao com o usuario, lendo tudo na mesma linha nome1, idade2,
            // recompensa3, nomePirata4 e coloque cada um em uma variavel separada
            string[] pirata = Console.ReadLine().Split(" ");
            string nome1 = pirata[0];
            int idade2 = int.Parse(pirata[1]);
            double recompensa3 = double.Parse(pirata[2], CultureInfo.InvariantCulture);
            string nomePirata4 = pirata[3];

            Console.WriteLine(nome1);
            Console.WriteLine(idade2);
            Console.WriteLine(recompensa3.ToString("F5", CultureInfo.InvariantCulture));
            Console.WriteLine(nomePirata4);



        }
    }
}