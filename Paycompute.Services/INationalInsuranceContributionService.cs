﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paycompute.Services
{
    public interface INationalInsuranceContributionService
    {
        decimal NIContribution(decimal totalAmount);
    }
}
