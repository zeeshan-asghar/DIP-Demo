using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Employee
    {
        public int EmpId { get;   set; }
        public string Name { get;   set; }
        public double Salary { get;   set; }
        public int DurationWorked { get;   set; }
        public int Grade { get;   set; }
    }


    public class EmployeeEntity
    {
        public List<Employee> EmployeesCollection = new List<Employee>() {
            new Employee {
                EmpId=1
                ,Name="name1"
                ,Salary = 4000.00
                ,DurationWorked=24
                ,Grade=1
            },
            new Employee {
                EmpId=2
                ,Name="name2"
                ,Salary = 350.00
                ,DurationWorked=1
                ,Grade=4
            },
        };
    }
}
