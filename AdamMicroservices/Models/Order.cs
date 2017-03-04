using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AdamMicroservices.Models
{
    [Table ("Orders", Schema = "Micro1")]
    public class Order
    {
        public int OrderId { get; set; }

        public String OrderNumber { get; set; }
    }
}