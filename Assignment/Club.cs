using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Club
    {
        public int ClubID { get; set; }
        public string? ClubName { get; set; }
        List<Employee> Members { get;  set; } = new List<Employee>();
        public void AddMember(Employee E)
        {
            Members.Add(E);
            E.EmployeeLayOff += RemoveMember;
        }
        ///CallBackMethod
        public void RemoveMember(object? sender, EmployeeLayOffEventArgs e)
        {
            Employee? employee = sender as Employee;
            if (employee != null && employee.VacationStock < 0)
                Members.Remove(employee);
        }
    }

}
