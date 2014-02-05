using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AccountManagement.ViewModels
{
    public class ApplyForLoanViewModel
    {
        [Display(ResourceType = typeof(ViewModelLabels), Name = "ApplyForLoanViewModel_FirstName")]
        [Required(ErrorMessageResourceType = typeof(ViewModelValidationErrors), ErrorMessageResourceName = "ApplyForLoanViewModel_FirstName_Required")]
        public string FirstName { get; set; }
        public decimal Amount { get; set; }

        public IEnumerable<PaymentPlanViewModel> Plans { get; set; }
    }
}