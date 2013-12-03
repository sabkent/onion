using Core.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class LoanClassMap : ClassMap<Loan>
    {
        public LoanClassMap()
        {
            Id(x => x.Id).Column("LoanId");
            Map(x => x.CustomerId);
        }
    }
}
