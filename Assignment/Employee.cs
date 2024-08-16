using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment;
class Employee
{
    public event EventHandler<EmployeeLayOffEventArgs>? EmployeeLayOff;
    public int EmployeeID { get; set; }
    public DateTime BirthDate { get; set;}
    protected virtual void OnEmployeeLayOff (EmployeeLayOffEventArgs e)
    {
        EmployeeLayOff?.Invoke (this, e);
    }
    public int VacationStock {  get; set; }
    public bool RequestVacation(DateTime From, DateTime To)
    {
        if (VacationStock > (To.Day - From.Day)) 
            return true;
        else
            return false;

    }
    public void EndOfYearOperation()
    {
        if (VacationStock < 0)
        {
            OnEmployeeLayOff(new EmployeeLayOffEventArgs() { Cause = LayOffCause.NegativeVacationStock});
        }
        int Age = DateTime.Now.Year - BirthDate.Year;
        if (Age > 60)
        {
            OnEmployeeLayOff(new EmployeeLayOffEventArgs() { Cause = LayOffCause.RetiringAge});
        }
    }
}
