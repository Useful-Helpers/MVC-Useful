using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using TestServices.Messaging;

namespace TestServices.Rest.Controllers
{
    public class DispatchController : ApiController
    {
        public void Post(Models.Order order)
        {
            ServiceBus.Bus.Send("ProcessOrder", new ProcessOrderCommand
            {
                AddressFrom = order.AddressFrom,
                AddressTo = order.AddressTo,
                Price = order.Price,
                Weight = order.Weight
            });
        }
    }
}