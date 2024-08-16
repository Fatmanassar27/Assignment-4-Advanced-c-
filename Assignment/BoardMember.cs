using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class BoardMember : Employee
    {
        public void Resign()
        {
            this.OnEmployeeLayOff(new EmployeeLayOffEventArgs() { Cause = LayOffCause.HeOrSheResigned });
        }

        protected override void OnEmployeeLayOff(EmployeeLayOffEventArgs e)
        {

            if (e.Cause == LayOffCause.NegativeVacationStock || e.Cause == LayOffCause.RetiringAge)
            { }
            else
                base.OnEmployeeLayOff(e);

        }
    }
}
