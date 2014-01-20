using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Core.ReadModel
{
    public interface IRepaymentReadModelRepository
    {
        IEnumerable<Repayment> GetAllForLoan(int loanId);
    }
}
