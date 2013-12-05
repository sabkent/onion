using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data
{
    public interface IOutstandingLoanRepository
    {
        OutstandingLoan GetById(int loanId);
    }
}
