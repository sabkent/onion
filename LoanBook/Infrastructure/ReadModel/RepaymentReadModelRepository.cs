using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ReadModel;
using MongoDB.Driver;
using NHibernate.Mapping;

namespace Infrastructure.ReadModel
{
    public sealed class RepaymentReadModelRepository : IRepaymentReadModelRepository
    {
        public IEnumerable<Repayment> GetAllForLoan(int loanId)
        {
            return new List<Repayment>
            {
                new Repayment()
            };
        }


        public void Add(Repayment repayment)
        {
            var client = new MongoClient("mongodb://localhost");
            var server = client.GetServer();
            var mongoDatabase = server.GetDatabase("LoanShark");
            
            var collection = mongoDatabase.GetCollection<Repayment>("ActiveRepayment");
            collection.Save(repayment);
        }
    }
}
