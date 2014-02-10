using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Core.Events;
using Messaging.ClientSide;
using Microsoft.AspNet.SignalR;

namespace Services.EventSubscribers
{
    public  class LoanApplicationAcceptedSignalClient : ISubscribeToEvent<LoanApplicationAccepted>
    {

        public void Notify(LoanApplicationAccepted @event)
        {
            Thread.Sleep(TimeSpan.FromSeconds(2));
            var loanApplicationHub = GlobalHost.ConnectionManager.GetHubContext<LoanApplication>();

            loanApplicationHub.Clients.All.complete();
        }
    }
}
