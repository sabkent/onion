using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Events;
using Core.ReadModel;

namespace Services.EventSubscribers
{
    public sealed class LoanApplicationAcceptedReadModelSync : ISubscribeToEvent<LoanApplicationAccepted>
    {
        private readonly IRepaymentReadModelRepository _repayments;

        public void Notify(LoanApplicationAccepted @event)
        {
            var repayment = new Repayment {LoanId = @event.LoanId};

            _repayments.Add(repayment);
        }
    }
}
