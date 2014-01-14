using Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Core.Entities;
using Infrastructure.Data;

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
            //var loan = _loanRepository.GetById(1);

            _loanRepository.Add(new Loan
                {
                    CustomerId = 1,
                    Payments = new List<Payment>
                        {
                            new Payment{Amount = 100, DueDate = DateTime.Now, StatusId = 1}
                        }
                });

            return View();
        }
    }
}
