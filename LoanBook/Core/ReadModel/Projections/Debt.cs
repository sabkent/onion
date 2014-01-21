using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ReadModel.Projections
{
    public sealed class Debt
    {
        public int Customer { get; set; }
        public string FirstName { get; set; }
        public DateTime Due { get; set; }
        public decimal Amount { get; set; }
    }
}
