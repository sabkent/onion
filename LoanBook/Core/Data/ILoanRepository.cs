﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data
{
    public interface ILoanRepository
    {
        Loan GetById(int loanId);
        void Add(Loan loan);
    }
}
