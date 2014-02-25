using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Data
{
    public interface ICustomerRepository
    {
        void Save(Customer customer);
    }
}
