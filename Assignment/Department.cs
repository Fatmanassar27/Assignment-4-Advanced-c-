using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Department
    {
        public int DeptID { get; set; }
        public string? DeptName { get; set; }

        List<Employee>? Staff { get; set; } = new List<Employee>();
        public void AddStaff(Employee E)
        {
            Staff?.Add(E);
            E.EmployeeLayOff += RemoveStaff ;
        }
        ///CallBackMethod
        public void RemoveStaff(object? sender,EmployeeLayOffEventArgs e)
        {
            Employee? employee = sender as Employee;
            if (employee != null) 
                 Staff?.Remove(employee);
        }
    }


}

