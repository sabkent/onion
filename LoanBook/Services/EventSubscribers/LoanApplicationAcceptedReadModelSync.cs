using System;
using Core.Events;
using Core.ReadModel;

namespace Services.EventSubscribers
{
    public sealed class LoanApplicationAcceptedReadModelSync : ISubscribeToEvent<LoanApplicationAccepted>
    {
        private readonly IRepaymentReadModelRepository _repayments;

        public LoanApplicationAcceptedReadModelSync(IRepaymentReadModelRepository repayments)
        {
            _repayments = repayments;
        }

        public void Notify(LoanApplicationAccepted @event)
        {
            var repayment = new Repayment {LoanId = @event.LoanId, RepaymentId = Guid.NewGuid()};

            _repayments.Add(repayment);
        }
    }
}
