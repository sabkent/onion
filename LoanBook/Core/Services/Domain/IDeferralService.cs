using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services.Domain
{
    public interface IDeferralService
    {
        void Defer(OutstandingLoan outstandingLoan);
    }
}
