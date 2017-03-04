using AdamMicroservices2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AdamMicroservices2
{
    public class CustomerContext : DbContext
    {
        public CustomerContext(): base ("AdamMicroservices")
        {

        }

        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("Micro2");
        }
    }
}