using AdamMicroservices.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AdamMicroservices
{
    // http://www.mortenanderson.net/code-first-migrations-for-entity-framework

    public class OrderContext : DbContext
    {
        public OrderContext (): base ("AdamMicroservices")
        {

        }

        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("Micro1");
        }
    }
}