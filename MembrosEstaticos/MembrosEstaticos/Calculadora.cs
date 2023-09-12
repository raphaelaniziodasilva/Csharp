using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembrosEstaticos {
    internal class Calculadora {
        // static = vai permitir que atributos sejam chamados sem precisar instanciar o objeto
        public static double Pi = 3.14;

        // static = vai permitir que metodos sejam chamados sem precisar instanciar o objeto

        public static double Circunferencia(double raio) {
            return 2.0 * double.Pi * raio;
        }

        // static = vai permitir que metodos sejam chamados sem precisar instanciar o objeto
        public static double Voliume(double raio) {
            return 4.0 / 3.0 * double.Pi * Math.Pow(raio, 2);

        }
    }
}
