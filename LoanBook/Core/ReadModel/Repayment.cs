using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ReadModel
{
    public class Repayment
    {
        public int LoanId { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaidDate { get; set; }
    }
}
