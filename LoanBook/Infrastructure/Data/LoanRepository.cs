using Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Infrastructure.Data
{
    public class LoanRepository : ILoanRepository
    {
        public Loan GetById(int loanId)
        {
            return new Loan();
        }
    }
}
