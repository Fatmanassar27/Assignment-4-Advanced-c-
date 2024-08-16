using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class SalesPerson : Employee
    {
        public int AchievedTarget { get; set; }
        public bool CheckTarget(int Quota)
        {
            if ( AchievedTarget < Quota)
                this.OnEmployeeLayOff(new EmployeeLayOffEventArgs() { Cause = LayOffCause.FailedtoAchieveSalesTarget});
            return AchievedTarget >= Quota;
        }
        protected override void OnEmployeeLayOff(EmployeeLayOffEventArgs e)
        {
            if (e.Cause == LayOffCause.NegativeVacationStock)
            { }
            else
               base.OnEmployeeLayOff(e);
            
        }
    }
}
