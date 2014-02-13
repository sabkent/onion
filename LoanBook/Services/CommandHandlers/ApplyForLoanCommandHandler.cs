using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using Core.Commands;
using Core.Data;
using Core.Entities;
using Core.Events;

namespace Services.CommandHandlers
{
    public sealed class ApplyForLoanCommandHandler : IHandleCommand<ApplyForLoan>
    {
        private readonly IRaiseEvents _publishEvents;
        private readonly ILoanRepository _repository;

        public ApplyForLoanCommandHandler(IRaiseEvents publishEvents, ILoanRepository repository)
        {
            _publishEvents = publishEvents;
            _repository = repository;
        }

        public void Handle(ApplyForLoan command)
        {
            //persist
            var customer = new Customer() {FirstName = command.FirstName};
            var loan = new Loan() {
                Amount = command.Amount, 
                Customer = customer,
                DueDate = DateTime.Now};

            _repository.Add(loan);
            _publishEvents.Publish(new LoanApplicationAccepted());
        }
    }
}
