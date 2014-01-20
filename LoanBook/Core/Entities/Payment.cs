using System;

namespace Core.Entities
{
    public class Payment
    {
        public virtual int PaymentId { get; set; }
        public virtual decimal Amount { get; set; }
        public virtual DateTime DueDate { get; set; }
        
        public virtual Loan Loan { get; set; }
    }
}
