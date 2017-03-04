using AdamMicroservices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AdamMicroservices.Controllers
{
    public class OrderController : ApiController
    {
        [HttpGet]
        public String Get ()
        {
            var context = new OrderContext();
            var order = new Order { OrderNumber = DateTime.UtcNow.ToString() };
            context.Orders.Add(order);
            context.SaveChanges();
 
            return "Hello World from Orders";
        }
    }
}
