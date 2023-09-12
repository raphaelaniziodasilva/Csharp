using System.Globalization;

namespace Arrays {
    internal class Program {
        static void Main(string[] args) {
            // VAMOS CRIAR LISTA DA CLASSE PRODUTOS

            // usuario vai digitar quantas posiçoes vai ter no array de produtos
            int n = int.Parse(Console.ReadLine());

            // criando a lista do tipo Produto, n = posiçoes que o usuario dig77itou
            Produto[] lista = new Produto[n];

            // percorrendo pela lista[]
            for (int i = 0; i < n; i++) {
                // digitando os valores do produto de cada posiçao do array
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                // criando produto para cada posiçao
                lista[i] = new Produto(nome, preco);
            }

            // media de preço dos produtos
            double valorTotal = 0.0;

            // percorrendo pela lista, n = posiçoes que o usuario digitou
            for (int i = 0; i < n; i++) {
                // somando todos os preco dos produtos e colocando na variavel valorTotal
                valorTotal += lista[i].Preco;
            }

            double mediaTotal = valorTotal / n;
            Console.WriteLine("Media total da lista de produtos R$: " + mediaTotal.ToString("F2", CultureInfo.InvariantCulture));


            /*
                // usuario vai digitar quantas posiçoes vai ter no array[]
                int n = int.Parse(Console.ReadLine());

                // criando array e o tipo em C#, n = posiçoes que o usuario digitou
                double[] array = new double[n];

                // percorrendo pelo array[]
                for(int i = 0; i < n; i++ ) {
                    // digitando os valores de cada posiçao do array
                    array[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }

                // media do array[]
                double soma = 0.0;
                for(int i = 0; i < n; i++) {
                    // somando todos os elementos do array[] e colocando na variavel soma
                    soma += array[i];
                }

                double media = soma / n;
                Console.WriteLine("Media dos elementos do array" + media.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}