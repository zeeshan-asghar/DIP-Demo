using Model.MOCK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockUI
{
    class Program
    {
        static void Main(string[] args)
        {
            int empId = 1;

            EmpPersonalDetails personalDetails = new EmpPersonalDetails();

            Model.Employee emp = personalDetails.GetEmployeeDetails(empId);

            Console.WriteLine("Year end bonus for the employee {0} is {1}"
                , emp.Name, emp.Salary);

            Console.WriteLine("Duration worked by employee {0} is {1}"
                , emp.Name, emp.DurationWorked);

            EmpPfDetails empPfDetails = new EmpPfDetails();

            Console.WriteLine("Employer contribution for employee {0} is {1}"
                , emp.Name, empPfDetails.GetEmployerCOntribution(empId));

            EmpBenefits empBenefits = new EmpBenefits();
            Console.WriteLine("Benefits of employee {0 }with grade 1 {1} are:" 
                , emp.Name, empBenefits.GetBasicBenefits(empId)); 

        }
    }
}
