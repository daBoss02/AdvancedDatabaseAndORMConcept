using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AdvancedDatabaseAndORMConcept.Models;

namespace AdvancedDatabaseAndORMConcept.Data
{
    public class AdvancedDatabaseAndORMConceptContext : DbContext
    {
        public AdvancedDatabaseAndORMConceptContext (DbContextOptions<AdvancedDatabaseAndORMConceptContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; } = default!;
        public DbSet<Address> Addresses { get; set; } = default!;
    }
}
