namespace Fintech.Entities {
    internal class LegalPerson : User {
        public string Cnpj { get; set; }

        public LegalPerson(string name, string surname, string dateOfBirth, string email, string cellPhone, string telephone, Address address, string cnpj)
            : base(name, surname, dateOfBirth, email, cellPhone, telephone, address) {
            Cnpj = cnpj;
        }
    }
}
