using Core.Data;
using System;
using System.Web.Mvc;
using Core.Entities;

namespace AccountManagement.Controllers
{
    public class HomeController : Controller
    {
        private ILoanRepository _loanRepository;

        public HomeController(ILoanRepository loanRepository)
        {
            _loanRepository = loanRepository;
        }

        public ActionResult Index()
        {
            var loan = new Loan
            {
                CustomerId = 1,
                Amount = 150,
                DueDate = DateTime.Now
                
            };
            loan.AcceptPayment(new Payment
            {
                Amount = 150,
                Date = DateTime.Now
            });

            _loanRepository.Add(loan);

            return View();
        }
    }
}
