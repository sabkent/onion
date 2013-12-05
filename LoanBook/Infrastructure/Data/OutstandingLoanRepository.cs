using Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Infrastructure.Data
{
    public class OutstandingLoanRepository : IOutstandingLoanRepository
    {
        public OutstandingLoan GetById(int loanId)
        {
            //what if we pass in a LoanId for a loan that is not outstanding. Our ORM will have to ensure this returns null
            return new OutstandingLoan();
        }
    }
}
