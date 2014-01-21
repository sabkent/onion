using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Events
{
    public sealed class LoanApplicationAccepted
    {
        public int LoanId { get; set; }
    }
}
