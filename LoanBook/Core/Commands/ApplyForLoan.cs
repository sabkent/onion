using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Commands
{
    public sealed class ApplyForLoan
    {
        public string FirstName { get; set; }
        public decimal Amount { get; set; }
    }
}
