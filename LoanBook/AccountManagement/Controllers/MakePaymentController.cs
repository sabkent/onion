using System.Collections.Generic;
using System.Web.Mvc;
using Core.Services.Application;
using AccountManagement.ViewModels;
using Core.Commands;
using Core.ReadModel;

namespace AccountManagement.Controllers
{
    public class MakePaymentController : Controller
    {
        private readonly IRepaymentReadModelRepository _repaymentReadModelRepository;
        private readonly IMakePaymentService _makePaymentService;

        public MakePaymentController(IRepaymentReadModelRepository repaymentReadModelRepository, IMakePaymentService makePaymentService)
        {
            _repaymentReadModelRepository = repaymentReadModelRepository;
            _makePaymentService = makePaymentService;
        }

        public ActionResult Index()
        {
            IEnumerable<Repayment> repayments = _repaymentReadModelRepository.GetAllForLoan(1);
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
