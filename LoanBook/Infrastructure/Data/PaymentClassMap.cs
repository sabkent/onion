﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
using FluentNHibernate.Mapping;

namespace Infrastructure.Data
{
    public class PaymentClassMap : ClassMap<Payment>
    {
        public PaymentClassMap()
        {
            Id(x => x.PaymentId);
            Map(x => x.DueDate);
            Map(x => x.Amount);
            Map(x => x.StatusId);

            References(x => x.Loan);
        }
    }
}