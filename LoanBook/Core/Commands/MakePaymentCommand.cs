using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Commands
{
    public class MakePaymentCommand
    {
        public MakePaymentCommand(int loanId, decimal amount)
        {
            LoanId = loanId;
            Amount = amount;
        }

        public int LoanId { get; private set; }
        public decimal Amount { get; private set; }
    }
}
