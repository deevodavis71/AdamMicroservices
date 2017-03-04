using AdamMicroservices2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AdamMicroservices2.Controllers
{
    public class CustomerController : ApiController
    {
        [HttpGet]
        public String Get()
        {
            var context = new CustomerContext();
            var order = new Customer { CustomerName = DateTime.UtcNow.ToString() };
            context.Customers.Add(order);
            context.SaveChanges();

            return "Hello World from Customers";
        }
    }
}
