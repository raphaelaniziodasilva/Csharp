using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria {
    internal class ContaB {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        // construtor com os atributos Numero e Titular
        public ContaB(int numero, string titular) {
            Numero = numero;
            Titular = titular;
        }

        // construtor com os atributos Numero, Titular e Saldo
        // : this(numero, titular) = reaproveitando o construtor de 2 argumentos acima
        public ContaB(int numero, string titular, double depositoInicial) : this(numero, titular) {
            Deposito(depositoInicial);
        }

        // metodo de deposito
        public void Deposito(double quantia) {
            Saldo += quantia;
        }

        // metodo de saque tem uma taxa de 5.0 a cada saque que for feito
        public void Saque(double quantia) {
            Saldo -= quantia + 5.0;
        }

        // escrita da conta para o usuario ToString
        public override string ToString() {
            return "Conta: " + Numero
                + ", Titular: " + Titular
                + ", Saldo R$: " + Saldo.ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}
