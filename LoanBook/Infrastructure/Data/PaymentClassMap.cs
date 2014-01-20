using System;
using Core.Entities;
using FluentNHibernate.Mapping;

namespace Infrastructure.Data
{
    public class PaymentClassMap : ClassMap<Payment>
    {
        public PaymentClassMap()
        {
            Id(x => x.PaymentId);
            Map(x => x.Date);
            Map(x => x.Amount);

            References(x => x.Loan).Column("LoanId").Not.Nullable();
        }
    }
}
