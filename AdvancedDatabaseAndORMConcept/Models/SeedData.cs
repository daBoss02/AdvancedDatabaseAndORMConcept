using AdvancedDatabaseAndORMConcept.Data;
using Microsoft.EntityFrameworkCore;

namespace AdvancedDatabaseAndORMConcept.Models
{
    public static class SeedData
    {
        public async static Task Initialize(IServiceProvider serviceProvider)
        {
            AdvancedDatabaseAndORMConceptContext context = new AdvancedDatabaseAndORMConceptContext(serviceProvider.GetRequiredService<DbContextOptions<AdvancedDatabaseAndORMConceptContext>>());
            Address Address1 = new Address("123 Fake Street", "72", "Winnipeg", "Manitoba", "Canada");
            Address Address2 = new Address("456 Fake Street", "43", "Winnipeg", "Manitoba", "Canada");
            Address Address3 = new Address("789 Fake Street", null, "Winnipeg", "Manitoba", "Canada");
            Customer Customer1 = new Customer("Joe", "Jones", "Jones Printing", "2045797234");
            Customer Customer2 = new Customer("Sally", "Miko", "Jones Printing", "1234567890");
            Customer Customer3 = new Customer("John", "Doe", "Inconspicuous conspicuousies", "8887509372");

            if (!context.Addresses.Any())
            {
                Address1.Customers.Add(Customer1);
                Address2.Customers.Add(Customer2);
                Address3.Customers.Add(Customer3);
                context.Addresses.Add(Address1);
                context.Addresses.Add(Address2);
                context.Addresses.Add(Address3);
            }

            if (!context.Customers.Any())
            {
                Customer1.Address = Address1;
                Customer2.Address = Address2;
                Customer3.Address = Address3;
                context.Customers.Add(Customer1);
                context.Customers.Add(Customer2);
                context.Customers.Add(Customer3);
            }


            await context.SaveChangesAsync();
        }
    }
}
