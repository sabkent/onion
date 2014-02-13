using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public class Loan
    {
        public Loan()
        {
           Payments = new List<Payment>();
        }
        public virtual int LoanId { get; set; }
        //public virtual int CustomerId { get; set; }

        public virtual decimal Amount { get; set; }

        public virtual DateTime DueDate { get; set; }

        public virtual IList<Payment> Payments { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual void AcceptPayment(Payment payment)
        {
            payment.Loan = this;
            Payments.Add(payment);
        }
    }
}
