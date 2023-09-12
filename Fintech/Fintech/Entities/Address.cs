namespace Fintech.Entities {
    internal class Address {
        public int ZipCode { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }
        public string Complement { get; set; }
        public string Neighborhood { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

        public Address(int zipCode, string street, int number, string complement, string neighborhood, string city, string state, string country) {
            ZipCode = zipCode;
            Street = street;
            Number = number;
            Complement = complement;
            Neighborhood = neighborhood;
            City = city;
            State = state;
            Country = country;
        }

        public override string ToString() {
            return "Address: " +
                 "Zip Code: " + ZipCode + ", " +
                 "Street: " + Street + ", " +
                 "Number: " + Number + ", " +
                 "Complement: " + Complement + ", " +
                 "Neighborhood: " + Neighborhood + ", " +
                 "City: " + City + ", " +
                 "State: " + State + ", " +
                 "Country: " + Country;
        }
    }

}
