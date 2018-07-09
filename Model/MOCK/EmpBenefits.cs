using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.MOCK
{
    public class EmpBenefits : IEmpBenefits
    {
        public List<string> GetAdditionalBenfits(int empId)
        {
            throw new NotImplementedException();
        }

        public List<string> GetBasicBenefits(int empId)
        { //Hospital, dental,Gym
            throw new NotImplementedException();
        }

        public int GetTotalBenefitsCount(int empId)
        {
            throw new NotImplementedException();
        }
    }

    public interface IEmpBenefits
    {
        List<string> GetBasicBenefits(int empId);
        List<string> GetAdditionalBenfits(int empId);
        int GetTotalBenefitsCount(int empId);
    }
}
