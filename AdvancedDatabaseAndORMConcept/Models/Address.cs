namespace AdvancedDatabaseAndORMConcept.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        public string City { get; set; }
        public string StateProvince { get; set; }
        public string CountryRegion { get; set; }
        public HashSet<Customer> Customers { get; set; } = new HashSet<Customer>();
        public Address() { }
        public Address(string address1, string address2, string city, string stateProvince, string countryRegion)
        {
            AddressLine1 = address1;
            AddressLine2 = address2;
            City = city;
            StateProvince = stateProvince;
            CountryRegion = countryRegion;
        }
    }
}
