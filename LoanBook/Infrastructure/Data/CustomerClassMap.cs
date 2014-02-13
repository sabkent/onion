using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
using FluentNHibernate.Mapping;

namespace Infrastructure.Data
{
    public class CustomerClassMap : ClassMap<Customer>
    {
        public CustomerClassMap()
        {
            Id(x => x.CustomerId); //.Column("LoanId").GeneratedBy.Native();
            Map(x => x.FirstName);
        }
    }
}
