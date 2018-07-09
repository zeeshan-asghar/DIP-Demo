using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.MOCK
{
    public class EmpPfDetails : IEmpPfDetails
    {
        private EmpPersonalDetails empPersonalDetails;

        public EmpPfDetails(EmpPersonalDetails empPersonalDetails)
        {
            this.empPersonalDetails = empPersonalDetails;
        }

        public int GetEmployerCOntribution(object empid)
        {
            throw new NotImplementedException();
        }

        public float GetPfEmployerControlSofar(int employeeId)
        {
            //Duration worked
            int totalDuration = empPersonalDetails.GetDurationWorked(employeeId);

            float salar = empPersonalDetails.GetEmployeeSalary(employeeId);

            var basic = (salar * 12) / 100;

            var contribution = (basic * 12) / 100;


            return totalDuration * contribution;
        }


        public float GetPfEmployeeControlSofar(int employeeId)
        {
            // Duration worked
            int totalDuration = empPersonalDetails.GetDurationWorked(employeeId);

            float salar = empPersonalDetails.GetEmployeeSalary(employeeId);

            var basic = (salar * 12) / 100;

            var contribution = (basic * 12) / 100;


            return totalDuration * contribution;
        }
    }

    public interface IEmpPfDetails
    {
        int GetEmployerCOntribution(int empid);

        float GetPfEmployerControlSofar(int employeeId);

        float GetPfEmployeeControlSofar(int employeeId);
    }
}
