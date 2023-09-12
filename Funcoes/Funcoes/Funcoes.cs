internal class Funcoes {
    private static void Main(string[] args) {
        Console.WriteLine("Digite três números:");
        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());
        int n3 = int.Parse(Console.ReadLine());

        // chamando a funçao Maior para fazer a verificaçao do maior valor
        double result = Maior(n1, n2, n3);

        Console.WriteLine("Maior = " + result);

    }

    static int Maior(int n1, int n2, int n3) {
        // vai ser atribuida o valor na verificaçao
        int maior;

        if(n1 > n2 && n1 > n3) {
            maior = n1;
        } else if(n2 > n3) {
            maior = n2;
        } else {
            maior = n3;
        }

        return maior;
    }
}