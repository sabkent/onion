using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccountManagement.ViewModels
{
    public class MakePaymentViewModel
    {
        public int LoanId { get; set; }
        public decimal Amount { get; set; }

        //public class PaymentInput
        //{
        //    public decimal Amount { get; set; }
        //}
    }
}