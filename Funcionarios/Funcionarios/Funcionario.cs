using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios {
    internal class Funcionario {
        public string Nome;
        public double SalarioBruto;
        public double Impostos;


        public double SalarioLiquido() {
            return SalarioBruto - Impostos;
        }

        public void AumentarSalario(double porcentagem) {
            SalarioBruto = SalarioBruto + (SalarioBruto * porcentagem / 100.0);
        }

        public override string ToString() {
            return Nome
                + ", salario R$: "
                + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
