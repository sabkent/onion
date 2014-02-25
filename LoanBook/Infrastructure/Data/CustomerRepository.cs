using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Data;
using Core.Entities;

namespace Infrastructure.Data
{
    public class CustomerRepository : ICustomerRepository
    {
        public void Save(Customer customer)
        {
            //var events = customer.GetUncommittedEvents();
        }
    }
}
