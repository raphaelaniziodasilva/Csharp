namespace Fintech.Entities {
    internal class PhysicalPerson : User {
        public string Rg { get; set; }
        public string Cpf { get; set; }

        public PhysicalPerson(string name, string surname, string dateOfBirth, string email, string cellPhone, string telephone, Address address, string rg, string cpf)
            : base(name, surname, dateOfBirth, email, cellPhone, telephone, address) {
            Rg = rg; 
            Cpf = cpf;
        }
    }
}
