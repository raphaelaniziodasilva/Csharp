﻿namespace SwitchCase {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite um número de 1 até 7");
            int numero = int.Parse(Console.ReadLine());

            string day;

            switch(numero) {
                case 1:
                    day = "Sunday";
                    break;
                case 2:
                    day = "Monday";
                    break;
                case 3:
                    day = "Tuesday";
                    break;
                case 4:
                    day = "Wednesday";
                    break;
                case 5:
                    day = "Thursday";
                    break;
                case 6:
                    day = "Friday";
                    break;
                case 7:
                    day = "Saturday";
                    break;
                default:
                    day = "Invalid value";
                    break;
            }
            Console.WriteLine("Day of the week: " + day);
        }
    }
}