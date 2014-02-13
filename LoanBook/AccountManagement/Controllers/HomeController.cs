using Core.Data;
using System;
using System.Web.Mvc;
using Core.Entities;

namespace AccountManagement.Controllers
{
    public class HomeController : Controller
    {
        private ILoanRepository _loanRepository;

        public HomeController()
        {
           
        }

        public ActionResult Index()
        {
            
           
            return View();
        }
    }
}
