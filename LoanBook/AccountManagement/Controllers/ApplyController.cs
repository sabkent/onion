using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AccountManagement.ViewModels;
using Core;
using Core.Commands;
using Messaging.ClientSide;
using Microsoft.AspNet.SignalR;

namespace AccountManagement.Controllers
{
    public class ApplyController : Controller
    {
        private readonly IDispatchCommands _dispatchCommands;
        //
        // GET: /Apply/
        public ApplyController(IDispatchCommands dispatchCommands)
        {
            _dispatchCommands = dispatchCommands;
        }

        public ActionResult Index()
        {
            return View(new ApplyForLoanViewModel
            {
                Plans = new List<PaymentPlanViewModel>
                {
                    new PaymentPlanViewModel{Id=  1, Name="Plan A"},
                    new PaymentPlanViewModel{Id = 2, Name="Plan B"}
                }
            });
        }

        [HttpPost]
        public ActionResult ApplyForLoan(ApplyForLoanViewModel model)
        {
            if (ModelState.IsValid)
            {
                var applyForLoanCommand = new ApplyForLoan {Amount = model.Amount, FirstName = model.FirstName};
                _dispatchCommands.Dispatch(applyForLoanCommand);
            }
         //   else { }

            return RedirectToAction("Complete");
        }

        public ActionResult Complete()
        {
            return View();
        }

        public void Test()
        {
            var applicationHub = GlobalHost.ConnectionManager.GetHubContext<LoanApplication>();

            applicationHub.Clients.All.complete();
        }
    }
}
