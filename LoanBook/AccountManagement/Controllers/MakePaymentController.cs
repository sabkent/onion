using Core.Data;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AccountManagement.Controllers
{
    public class MakePaymentController : Controller
    {
        private ILoanRepository _LoanRepository;

        public MakePaymentController(ILoanRepository loanRepository)
        {
            _LoanRepository = loanRepository;
        }


        public ActionResult Index()
        {
            var loan = new Loan
                {
                    CustomerId = 1,
                    Payments = new List<Payment>
                        {
                            new Payment{Amount = 129.95m, DueDate = DateTime.Now.AddDays(10), StatusId = 1}
                        }
                };

            _LoanRepository.Add(loan);

            return View();
        }

    }
}
