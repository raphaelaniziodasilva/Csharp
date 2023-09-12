using System;
using System.Globalization; // importando para conseguir usar . para fazer a separaçao dos números ex: 14.20

namespace MyApp { // Note: actual namespace depends on the project name.
    internal class AprendendoC {
        static void Main(string[] args) {
            // criando variavel do tipo byte = o byte nao aceita número negativo e vai de 0 ate 255
            byte n1 = 254;
            Console.WriteLine(n1); // imprimindo no terminal

            // incrementando o valor de n1 que de 254 vai passar a ser 255
            n1++;
            Console.WriteLine(n1);

            // variavel do tipo inteiro que recebe no maximo 2147483647
            int n2 = 2147483647;
            Console.WriteLine(n2); // imprimindo no terminal

            // variavel do tipo longa que recebe no maximo 2147483647834343493L 
            long n3 = 2147483647834343493L;
            Console.WriteLine(n3); // imprimindo no terminal

            // variavel do tipo bool: boolean que recebe verdadeiro ou false
            bool completo = false;
            Console.WriteLine(completo);

            // variavel do tipo char recebe um unico caractere unicode e tem que estar dentro de ''
            char genero = 'M';
            Console.WriteLine(genero);

            // variavel do tipo float recebe números com ponto flutuante porém para identificar que e um float precisamos colocar o f na frente do número
            float n4 = 4.4f;
            Console.WriteLine(n4);

            // variavel do tipo double recebe números com ponto flutuante
            double n5 = 4.4f;
            Console.WriteLine(n5);

            // variavel do tipo string recebe um texto ou frases
            string nome = "Sanji o cozinheiro";
            Console.WriteLine(nome);

            Console.WriteLine("-------------------");

            // Saída de dados
            double saldo = 17.88976;

            // imprimindo o saldo com casas decimais "F2" = igual a duas casas e assim por diante
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F3"));
            // no lugar da , vamos utilizar o . para fazer a separaçao dos números ex: 14.20
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));

            Console.WriteLine("-------------------");

            string pessoa = "Joker"; // {0}
            char sexo = 'M';// {2}
            int idade = 33; // {1}
            double valor = 22.34982; // {3:F2}

            // imprimindo os dados utilizando a tecnica do placeholders
            Console.WriteLine("{0} tem {1} anos, sexo {2} e o saldo de {3:F2} reais", pessoa, idade, sexo, valor);

            // imprimindo os dados utilizando a tecnica do interpolaçao
            Console.WriteLine($"{pessoa} tem {idade} anos e do sexo {sexo} e tem na conta R$:{saldo:F3}");

            Console.WriteLine("-------------------");

            // Conversao Implícita Casting
            float x = 4.5f;
            // convertendo uma variavel float para double
            double y = x;
            Console.WriteLine(y);

            // convertendo a variavel double para float
            double a = 10;
            float b = (float)a;
            Console.WriteLine(b);


            // convertendo uma divisao de int que vai receber double
            int a1 = 5;
            int b1 = 2;
            double result = (double) a1 / b1;
            Console.WriteLine(result);

            Console.WriteLine("-------------------");

            // Entrada de dados em C# - PARTE 1 vamos fazer o usuario interagir
            // Console.ReadLine() vai fazer com que o usuario digite no terminal
            string frase = Console.ReadLine();
            string x1 = Console.ReadLine();
            string y1 = Console.ReadLine();
            string z1 = Console.ReadLine();

            // imprimindo no terminal assim que o usuario digitar
            Console.WriteLine("Você digitou ");
            Console.WriteLine(frase);
            Console.WriteLine(x1);
            Console.WriteLine(y1);
            Console.WriteLine(z1);

            // o usuario vai digitar 3 cores, vamos pegar cada cor e colocar dentro de uma variavel
            // o Split(' ') vai ajudar a separar as cores atraves do espaço 
            string[] cores = Console.ReadLine().Split(' ');
            // colocando cada cor em uma variavel
            string cor1 = cores[0];
            string cor2 = cores[1];
            string cor3 = cores[2];

            // imprimindo as cores
            Console.WriteLine(cor1);
            Console.WriteLine(cor2);
            Console.WriteLine(cor3);

            Console.WriteLine("-------------------");

            // Entrada de dados em C# - PARTE 2 vamos fazer o usuario interagir
            // Console.ReadLine() = so le string precisamos converter de string para ler inteiro
            int c1 = int.Parse(Console.ReadLine());

            // convertendo o Console.ReadLine() para ler char
            char ch = char.Parse(Console.ReadLine());

            // convertendo o Console.ReadLine() para ler double
            //  no lugar da , vamos utilizar o . para fazer a separaçao dos números ex: 14.20
            double c2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // imprimindo
            Console.WriteLine("Você digitou");
            Console.WriteLine(c1);
            Console.WriteLine(ch);
            // imprimindo c2 com duas casas decimais e lendo a separaçao com .
            Console.WriteLine(c2.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("-------------------");

            // o usuario vai digitar nome, sexo, idade e altura, vamos pegar cada informaçao e colocar dentro de uma variavel
            // o Split(' ') vai ajudar a separar as informaçoes atraves do espaço
            string[] usuario = Console.ReadLine().Split(' ');
            // colocando cada informaçao em uma variavel
            string name = usuario[0];
            char sex = char.Parse(usuario[1]);
            int idad = int.Parse(usuario[2]);
            //  no lugar da , vamos utilizar o . para fazer a separaçao dos números ex: 1.62
            double altura = double.Parse(usuario[3], CultureInfo.InvariantCulture);

            Console.WriteLine("Informaçoes do usuario");
            Console.WriteLine(name);
            Console.WriteLine(sex);
            Console.WriteLine(idad);
            // imprimindo a altura com duas casas decimais e lendo a separaçao com .
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}