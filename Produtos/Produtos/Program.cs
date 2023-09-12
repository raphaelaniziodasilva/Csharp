using System.Globalization;

namespace Produtos {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite os dados do Produto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());
    
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // criar o produto e tipar com a classe Produto: instanciando a classe
            Produto prod = new Produto(nome, quantidade, preco);

            // utilizando o metodo ToString() para converter o produto para string
            Console.WriteLine("Dados do Produto: " + prod);

            Console.WriteLine();
            Console.Write("Digite a quantidade de produtos a ser adicionado no estoque: ");
            int qte = int.Parse(Console.ReadLine());
            // utilizando o metodo AdicionarProdutos para adicionar a quantidade que o 
            // usuario digitou no estoque
            prod.AdicionarProdutos(qte);


            // utilizando o metodo ToString() para converter o produto para string
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + prod);

            Console.WriteLine();
            Console.Write("Digite a quantidade de produtos a ser removido do estoque: ");
            // reaproveitando a variavel qte que nao pode ser mais declarada
            qte = int.Parse(Console.ReadLine());
            // utilizando o metodo RemoverProdutos para diminuir a quantidade que o 
            // usuario digitou do estoque
            prod.RemoverProdutos(qte);


            // utilizando o metodo ToString() para converter o produto para string
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + prod);

            // chamando a propriedade Nome: set que esta na classe Produto
            prod.Nome = "TV 4K";
            Console.WriteLine(prod.Nome);
            Console.WriteLine(prod.Quantidade);
            Console.WriteLine(prod.Preco);

        }
    }
}