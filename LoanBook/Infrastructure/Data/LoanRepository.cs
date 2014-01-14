using Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
using NHibernate;
using NHibernate.Linq;

namespace Infrastructure.Data
{
    public class LoanRepository : ILoanRepository
    {
        private ISessionFactory _sessionFactory;

        public LoanRepository(ISessionFactory sessionFactory)
        {
            _sessionFactory = sessionFactory;
        }

        public Loan GetById(int loanId)
        {
            using (var session = _sessionFactory.OpenSession())
            {
                return session.Query<Loan>().FirstOrDefault(l => l.Id == loanId);
            }
        }

        public void Add(Loan loan)
        {
            using (var session = _sessionFactory.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.Save(loan);
                    transaction.Commit();
                }
            }
        }
    }
}
