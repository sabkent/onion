using Core.Commands;
using Core.Data;
using Core.Entities;
using Core.Services.Application;

namespace Services.Application
{
    public class MakePaymentService : IMakePaymentService
    {
        private readonly ILoanRepository _loanRepository;
        
        public MakePaymentService(ILoanRepository loanRepository)
        {
            _loanRepository = loanRepository;
        }

        public MakePaymentResult MakePayment(MakePaymentCommand makePaymentCommand)
        {
            var loan = _loanRepository.GetById(makePaymentCommand.LoanId);
            
            var payment = new Payment {Amount = makePaymentCommand.Amount};

            loan.AcceptPayment(payment);

            return new MakePaymentResult();
        }
    }
}
