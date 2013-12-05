using Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services.Application
{
    public class MakePaymentService : IMakePaymentService
    {
        private readonly ILoanRepository _loanRepository;


        public MakePaymentService(ILoanRepository loanRepository)
        {
            _loanRepository = loanRepository;
        }

        public void MakePayment(int loan, decimal amount)
        {
            
        }
    }
}
