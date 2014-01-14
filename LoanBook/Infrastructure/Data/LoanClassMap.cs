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
            Id(x => x.Id).Column("LoanId").GeneratedBy.Native();
            Map(x => x.CustomerId);

            //http://stackoverflow.com/questions/11182177/with-fluent-nhibernate-i-cant-get-child-objects-to-save-with-parent-object-id-i
            //http://stackoverflow.com/questions/5235311/fluent-nhibernate-cascade-issue-trying-to-insert-null-id
            //HasMany(x => x.Payments).KeyColumn("LoanId")
            //                        .Cascade
            //                        .All();


            HasMany(x => x.Payments).KeyColumn("LoanId")
                                    //.Inverse()
                                    .Cascade.All();
                                    //.Not.LazyLoad();

        }
    }
}
