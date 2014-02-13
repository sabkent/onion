using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ReadModel
{
    public sealed class Repayment
    {
        public Guid RepaymentId { get; set; }
        public int LoanId { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaidDate { get; set; }
    }
}
