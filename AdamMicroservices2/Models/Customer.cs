using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AdamMicroservices2.Models
{
    [Table ("Customers", Schema = "Micro2")]
    public class Customer
    {
        public int CustomerId { get; set; }

        public String CustomerName { get; set; }
    }
}