﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public enum LayOffCause
    {
        NegativeVacationStock,
        RetiringAge ,
        HeOrSheResigned,
        FailedtoAchieveSalesTarget
    }

    public class EmployeeLayOffEventArgs
    {
        public LayOffCause Cause { get; set; }
    }

}
