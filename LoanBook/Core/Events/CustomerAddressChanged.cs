using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Events
{
    public class CustomerAddressChanged : IEvent
    {
        public string Number { get; set; }
        public string Street { get; set; }
    }
}
