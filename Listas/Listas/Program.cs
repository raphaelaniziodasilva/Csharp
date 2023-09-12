using System.Collections.Generic;
namespace Listas {
    internal class Program {
        static void Main(string[] args) {
            // vamos criar uma lista mais antes para poder criar a lista precisamos importar a System.Collections.Generic
            List<string> list = new List<string>();

            // adicionando elementos na lista
            list.Add("Doffy");
            list.Add("Zoro");
            list.Add("Luffy");
            list.Add("Almirante");
            list.Add("Marinha");
            list.Add("Baby 5");
            // adicionando elementos na lista em uma posiçao especifica, vamos adicionar na posiçao 2
            list.Insert(2, "Robin");
            // vamos adicionar na posiçao 0
            list.Insert(0, "Law");

            // vamos percorrer por cada elemento da lista usando o foreach e pedir para imprimir os elementos
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

            Console.WriteLine("-----------------------");

            // mostrar o tamanho da lista ou seja quantos elementos tem na lista
            Console.WriteLine("Tem " + list.Count + " Elementos na lista");

            // encontrar o primeiro elemento da lista que começa com a letra Z
            string first = list.Find(x => x[0] == 'Z');
            Console.WriteLine("Primeiro elemento que começa com a letra Z " +first);

            // encontrar o último elemento da lista que começa com a letra L
            string last = list.FindLast(x => x[0] == 'L');
            Console.WriteLine("Último elemento que começa com a letra L " + last);

            // encontrar a primeira posiçao de elemento da lista que começa com a letra L
            int firstPosition = list.FindIndex(x => x[0] == 'L');
            Console.WriteLine("Primeira posiçao de elemento que começa com a letra L " + firstPosition);

            // encontrar a última posiçao de elemento da lista que começa com a letra L
            int lastPosition = list.FindLastIndex(x => x[0] == 'L');
            Console.WriteLine("Última posiçao de elemento que começa com a letra L " + lastPosition);

            Console.WriteLine("-----------------------");

            // filtrar a lista = vamos criar uma nova lista contendo apenas os elementos que tenha 5 caractere
            List<string> list2 = list.FindAll(x => x.Length == 5);
            // vamos percorrer por cada elemento da nova lista e imprimir os elementos
            foreach(string obj in list2) {
                Console.WriteLine(obj);
            }

            Console.WriteLine("-----------------------");

            // remover elemento da lista
            list.Remove("Zoro");
            // vamos percorrer por cada elemento da lista e imprimir os elementos para ver se o Zoro foi removido
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

            Console.WriteLine("-----------------------");

            // remover todos os elementos da lista que começa com a letra L
            list.RemoveAll(x => x[0] == 'L');
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

            Console.WriteLine("-----------------------");

            // removendo um elemento da lista pela posiçao dele
            list.RemoveAt(0);
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

            Console.WriteLine("-----------------------");

            // removendo elementos a partir da posiçao 1 vai remover 2 elementos
            list.RemoveRange(0, 2);
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

        }
    }
}