using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestServices.Rest.Models
{
    public class Order
    {
        public string AddressFrom { get; set; }

        public string AddressTo { get; set; }
        public int Weight { get; set; }

        public int Price { get; set; }
    }
}