using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortunaFirstBank {
    internal class BankAccount {
        public string _titular;
        public int Agencia { get; private set; }
        public int Numero { get; private set; }
        public double Saldo { get; private set; }

        public BankAccount(string titular, int agencia, int numero ) {
            _titular = titular;
            Agencia = agencia;
            Numero = numero;
        }

        public string Titular {
            get { return _titular; }
            set {
                if(value.Length > 1 && value != null) {
                    _titular = value;
                }
            }
        }

        public void Depositar(double valor) {
            Saldo += valor;
        }

        public bool Saque(double valor) {
            if(Saldo >= valor) {
                Saldo -= valor + 2.50;
                return true;
            } else {
                Console.WriteLine("Valor do saldo insuficiente para saque");
                return false;
            }
        }

        public bool Transferir(double valor, BankAccount contaDestino ) {
            if (Saldo >= valor) {
                Saldo -= valor + 3.0;
                contaDestino.Depositar(valor);
                Console.WriteLine("Transferencia concluída com sucesso");
                return true;
            }
            else {
                Console.WriteLine("Valor do saldo insuficiente para transferência");
                return false;
            }
        }

        public override string ToString() {
            return "Titular: " + _titular
                + ", Agencia: " + Agencia
                + ", Numero: " + Numero
                + ", Saldo R$: " + Saldo.ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}


