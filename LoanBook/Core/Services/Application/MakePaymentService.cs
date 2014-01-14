using Core.Commands;
using Core.Data;
using Core.Entities;
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

        public void MakePayment(MakePaymentCommand makePaymentCommand)
        {
            var loan = _loanRepository.GetById(makePaymentCommand.LoanId);

            var payment = new Payment {Amount = makePaymentCommand.Amount};

            loan.AcceptPayment(payment);
        }
    }
}
