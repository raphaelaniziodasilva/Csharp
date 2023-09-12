namespace AluguelQuartos {
    internal class Program {
        static void Main(string[] args) {
            Estudantes[] aluguelQuartos = new Estudantes[10];

            Console.WriteLine("Quantos quartos você deseja alugar: ?");
            int quartos = int.Parse(Console.ReadLine());

            for(int i = 1; i <= quartos; i++) {
                Console.WriteLine();
                Console.WriteLine($"Aluguel #{i}:");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                aluguelQuartos[quarto] = new Estudantes(nome, email);

            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados:");
            for (int i = 0; i < 10; i++) {
                if (aluguelQuartos[i] != null) {
                    Console.WriteLine(i + ": " + aluguelQuartos[i]);
                }
            }
        }
    }
}