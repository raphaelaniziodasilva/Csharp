using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produtos {
    internal class Produto {
        private string _nome;

        // vamos usar propriedades autoimplementadas: é uma forma simplificada de se declarar
        // propriedades que nao necessitam de lógicas particlares para as operaçoes get e set

        // get e utilizado para ter acesso ao atributo fora da classe
        // set e utilizado para alterar ao atributo fora da classe quando esta private
        public int Quantidade { get; private set; }
        public double Preco { get; private set; }


        // inicializando o construtor
        public Produto(string nome, int quantidade, double preco) {
            _nome = nome;
            Quantidade = quantidade;
            Preco = preco;
        }

        // vamos utilizar a propriedade: property Nome
        public string Nome {
            // metodo get e utilizado para ter acesso ao atributo fora da classe quando esta private
            get { return _nome; }

            // metodo set e utilizado para alterar ao atributo fora da classe quando esta private
            set {
                // value:nome nao pode ser nulo e tem que ter mais de um caractere
                if (value != null && value.Length > 1) {
                    _nome = value;
                }
            }
        }


        /*
          metodo get e utilizado para ter acesso ao atributo fora da classe quando esta private
        public string GetNome() {
            return _nome;
         }

         metodo set e utilizado para alterar ao atributo fora da classe quando esta private
         o metodo vai ser do tipo void porque nao vai retornar nada como saida ele so vai alterar o valor do nome
         public void SetNome(string nome) {
            // nome nao pode ser nulo e tem que ter mais de um caractere
            if(nome != null && nome.Length > 1) {
                _nome = nome;
            }
         }

         public int GetQuantidade () {
            return _quantidade;
         }

         public double GetPreco() {
            return _preco;
         }
        */

        // calcular o valor do estoque
        public double ValorEmEstoque() {
            return Preco * Quantidade;
        }

        // adicionando produto, esse metodo vai ser do tipo void porque nao vai
        // retornar nenhum valor de saida e sim adicionar no atributo quantidade
        public void AdicionarProdutos(int quantidade) {
            Quantidade += quantidade;
        }

        // removendo produto, esse metodo vai ser do tipo void porque nao vai
        // retornar nenhum valor de saida e sim diminuir no atributo quantidade
        public void RemoverProdutos(int quantidade) {
            Quantidade -= quantidade;
        }

        // converter o produto:objeto para string
        public override string ToString() {
            return _nome
                + ", " + Quantidade + " unidades, "
                + " R$: " + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + " Toal R$: " + ValorEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
