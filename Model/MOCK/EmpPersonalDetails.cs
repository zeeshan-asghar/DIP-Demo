using System;
using System.Collections.Generic;

namespace Model.MOCK
{
    public class EmpPersonalDetails : IEmpPersonalDetails
    {
        public void AddEmployeeDetails(List<Employee> employees)
        {
            throw new NotImplementedException();
        }

        public Employee GetEmployeeDetails(int empId)
        {
            throw new NotImplementedException();
        }

        public void SaveEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        internal int GetDurationWorked(int employeeId)
        {
            throw new NotImplementedException();
        }

        int IEmpPersonalDetails.GetDurationWorked(int employeeId)
        {
            throw new NotImplementedException();
        }

        internal float GetEmployeeSalary(int employeeId)
        {
            throw new NotImplementedException();
        }

        float IEmpPersonalDetails.GetEmployeeSalary(int employeeId)
        {
            throw new NotImplementedException();
        }
    }

    public interface IEmpPersonalDetails
    {
        Employee GetEmployeeDetails(int empId);

        void SaveEmployee(Employee employee);

        void AddEmployeeDetails(List<Employee> employees);

        int GetDurationWorked(int employeeId);

        float GetEmployeeSalary(int employeeId);
    }
}
