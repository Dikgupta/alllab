using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApplication
{
    public class Employee
    {
        int empid;
        string name;
        double sal;

        public int EmployeeID
        {
            get { return empid; }
            set { empid = value; }
        }

        public string EmployeeName
        {
            get { return name; }
            set { name = value; }
        }

        public double Salary
        {
            get { return sal; }
            set { sal = value; }
        }
    }
}
