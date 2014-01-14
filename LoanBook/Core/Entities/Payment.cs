using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Payment
    {
        public virtual int PaymentId { get; set; }
        public virtual decimal Amount { get; set; }
        public virtual DateTime DueDate { get; set; }
        public virtual int StatusId { get; set; }

        //public virtual Loan Loan { get; set; }
    }
}
