namespace Heranca.Entities {
    internal class SavingsAccount : Account {
        public double InterestRate { get; set; }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance) {
            InterestRate = interestRate;
        }
            
        public void UpdateBalance() {
            Balance += Balance * InterestRate;
        }

        // vamos sobreescrever o metodo Withdraw da classe pai Account que tem o virtual
        public override void Withdraw(double amount) {
            // base = vamos reaproveitar a operaçao da superclasse e depois acrecentando outras coisas
            // efetuando o saque do metodo Withdraw conforme a regra que esta implementada no metodo
            base.Withdraw(amount);
            // agora vamos descontar mais 2 reais
            Balance -= 2.0;
        }
    }
}
