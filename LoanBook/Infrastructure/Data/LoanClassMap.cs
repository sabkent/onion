using Core.Entities;
using FluentNHibernate.Mapping;

namespace Infrastructure.Data
{
    public class LoanClassMap : ClassMap<Loan>
    {
        public LoanClassMap()
        {
            Id(x => x.LoanId);//.Column("LoanId").GeneratedBy.Native();
            //Map(x => x.CustomerId);
            References(x => x.Customer).Column("CustomerId").Cascade.All();
            Map(x => x.Amount);
            Map(x => x.DueDate);

            HasMany(x => x.Payments).KeyColumn("LoanId").Cascade.All();

            //http://stackoverflow.com/questions/11182177/with-fluent-nhibernate-i-cant-get-child-objects-to-save-with-parent-object-id-i
            //http://stackoverflow.com/questions/5235311/fluent-nhibernate-cascade-issue-trying-to-insert-null-id
            //HasMany(x => x.Payments).KeyColumn("LoanId")
            //                        .Cascade
            //                        .All();


            //HasMany(x => x.Payments).KeyColumn("LoanId")
            //.Inverse()
            //.Cascade.All();
            //.Not.LazyLoad();

        }
    }
}
