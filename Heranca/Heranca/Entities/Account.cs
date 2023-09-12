namespace Heranca.Entities {
    // classes abstract sao classes que nao podem ser instanciadas, é uma forma de garantir herança total
    // somente subclasses nao abstratas podem ser instanciadas, mas nunca a superclasse abstrata
    abstract internal class Account {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        // protected = modificador de acesso que especifica a visibilidade e acessibilidade de um membro da classe 
        public double Balance { get; protected set; }

        public Account(int number, string holder, double balance) {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        // virtual = vai dizer que o metodo que o utiliza ele pode ser sobreescrito ou sobreposto nas subclasses
        public virtual void Withdraw(double amount) {
            Balance -= amount + 5.0;
        }

        public void Deposit(double amount) {
            Balance += amount;
        }
    }
}
