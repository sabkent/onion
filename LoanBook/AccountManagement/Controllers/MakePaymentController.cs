using Core.Data;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Core.Services.Application;
using AccountManagement.ViewModels;
using Core.Commands;

namespace AccountManagement.Controllers
{
    public class MakePaymentController : Controller
    {
        private IMakePaymentService _makePaymentService;

        public MakePaymentController(IMakePaymentService makePaymentService)
        {
            _makePaymentService = makePaymentService;
        }

        public ActionResult Index()
        {
            DependencyResolver.Current.GetService<ILoanRepository>()
                              .Add(new Loan
                                  {
                                      CustomerId = 1,
                                      Payments =
                                          new List<Payment>
                                              {
                                                  new Payment {Amount = 100, DueDate = DateTime.Now, StatusId = 1}
                                              }
                                  });
            return View();
        }

        [HttpPost]
        public ActionResult Index(MakePaymentViewModel makePaymentViewModel)
        {
            var makePaymentCommand = new MakePaymentCommand(makePaymentViewModel.LoanId, makePaymentViewModel.Amount);

            _makePaymentService.MakePayment(makePaymentCommand);

            return View();
        }

    }
}
