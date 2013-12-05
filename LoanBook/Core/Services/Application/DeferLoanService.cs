using System.Data;
using Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Services.Domain;

namespace Core.Services.Application
{
    public class DeferLoanService
    {
        private IOutstandingLoanRepository _outstandingLoans;
        private IDeferralService _deferralService;

        public void Defer(int loanId)
        {
            var loan = _outstandingLoans.GetById(loanId);
            
            if (loan == null) //--loan does not exist, or loan does not exist in outstanding state
                throw new Exception(String.Format("No outstanding loan with id {0}", loanId));

            _deferralService.Defer(loan);
        }

    }
}
