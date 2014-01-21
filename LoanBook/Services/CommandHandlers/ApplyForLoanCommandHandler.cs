using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using Core.Commands;
using Core.Events;

namespace Services.CommandHandlers
{
    public sealed class ApplyForLoanCommandHandler : IHandleCommand<ApplyForLoan>
    {
        private readonly IRaiseEvents _publishEvents;

        public ApplyForLoanCommandHandler(IRaiseEvents publishEvents)
        {
            _publishEvents = publishEvents;
        }

        public void Handle(ApplyForLoan command)
        {
            //persist

            _publishEvents.Publish(new LoanApplicationAccepted());
        }
    }
}
