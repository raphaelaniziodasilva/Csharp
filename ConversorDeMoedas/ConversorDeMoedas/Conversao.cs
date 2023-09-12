using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorDeMoedas {
    internal class Conversao {
        public static double Iof = 6.0;

        public static double ConverterDolarEmReal(double quantia, double cotacao) {
            double total = quantia * cotacao;
            return total + total * Iof / 100.0;

        }
    }
}
