﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Loan
    {
        public virtual int Id { get; set; }
        public virtual int CustomerId { get; set; }
    }
}
