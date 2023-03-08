using AdvancedDatabaseAndORMConcept.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Net;

namespace AdvancedDatabaseAndORMConcept.Models.ViewModels
{
    public class CustomerAddressVM
    {
        public List<SelectListItem> Addresses { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> Customers { get; set; } = new List<SelectListItem>();

        public int CustomerId { get; set; }
        public int AddressId { get; set; }

        public Customer? Customer { get; set; }
        public Address? Address { get; set; }
        public CustomerAddressVM() { }
        public CustomerAddressVM (List<Address> addresses, List<Customer> customers)
        {
            foreach (Address address in addresses)
            {
                Addresses.Add(new SelectListItem(address.AddressLine1, address.Id.ToString()));
            }
            foreach (Customer customer in customers)
            {
                Customers.Add(new SelectListItem(customer.FirstName + customer.LastName, customer.Id.ToString()));
            }
        }
        public CustomerAddressVM(List<Address> addresses, List<Customer> customers, int CustomerId, int AddressId)
        {
            foreach (Address address in addresses)
            {
                Addresses.Add(new SelectListItem(address.AddressLine1, address.Id.ToString()));
            }
            foreach (Customer customer in customers)
            {
                Customers.Add(new SelectListItem(customer.FirstName + customer.LastName, customer.Id.ToString()));
            }

            Customer = customers.First(customer => customer.Id == CustomerId);
            Address = addresses.First(address => address.Id == AddressId);
        }
    }
}
