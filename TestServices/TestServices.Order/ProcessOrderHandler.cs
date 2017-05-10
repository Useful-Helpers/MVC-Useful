using NServiceBus;
using NServiceBus.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestServices.Messaging;

namespace TestServices.Order
{
    public class ProcessOrderHandler : IHandleMessages<ProcessOrderCommand>
    {
        public ProcessOrderHandler(IBus bus)
        {

        }

        private static readonly ILog Logger = LogManager.GetLogger(typeof(ProcessOrderHandler));
       
        public void Handle(ProcessOrderCommand message)
        {
            Logger.InfoFormat("Order receivedd From Address {0} To Addres {1}", message.AddressFrom, message.AddressTo);
         //   EmailSender.SendEmailToDispatch(message);
        }
    }
}
