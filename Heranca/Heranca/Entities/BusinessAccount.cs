namespace Heranca.Entities {
    // para fazer a herança em C# em vez de usar extends vamos usar : e o nome da classe que queremos herdar
    internal class BusinessAccount : Account {
        public double LoanLimite { get; set; }

        public BusinessAccount(int number, string holder, double balance, double loanLimite)
            : base(number, holder, balance) {
            LoanLimite = loanLimite;
        }

        public void Loan(double amount) {
            if(amount <= LoanLimite) {
                Balance += amount;
            }
        }

    }
}
