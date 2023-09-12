namespace Fintech.Entities {
    internal class User {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string DateOfBirth { get; set; }
        public string Email { get; set; }
        public string CellPhone { get; set; }
        public string Telephone { get; set; }
        public Address Address { get; set; }

        public User(string name, string surname, string dateOfBirth, string email, string cellPhone, string telephone, Address address) {
            Name = name;
            Surname = surname;
            DateOfBirth = dateOfBirth;
            Email = email;
            CellPhone = cellPhone;
            Telephone = telephone;
            Address = address;
        }

        public override string ToString() {
            return "Name: " + Name + "\n" +
                    "Surname: " + Surname + "\n" +
                    "Date of Birth: " + DateOfBirth + "\n" +
                    "Email: " + Email + "\n" +
                    "Cell Phone: " + CellPhone + "\n" +
                    "Telephone: " + Telephone + "\n" +
                    "Address: " + Address;
        }
    }
}
