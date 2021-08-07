using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MigrationsAPp.Model
{
    class AurionProDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
    }
}
