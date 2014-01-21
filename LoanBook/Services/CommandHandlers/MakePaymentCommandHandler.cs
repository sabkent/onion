using Core.Commands;
using Core.Data;
using System;
using Core.Entities;
using Core.ReadModel.Projections;

namespace Services.CommandHandlers
{
    public class MakePaymentCommandHandler : IHandleCommand<MakePaymentCommand>
    {
        private readonly ILoanRepository _loanRepository;


        public MakePaymentCommandHandler(ILoanRepository loanRepository)
        {
            _loanRepository = loanRepository;
        }

        public void Handle(MakePaymentCommand command)
        {
            var loan = _loanRepository.GetById(command.LoanId);
            var payment = new Payment {Amount = command.Amount};

            loan.AcceptPayment(payment);

            _loanRepository.Add(loan);
        }
    }
}
