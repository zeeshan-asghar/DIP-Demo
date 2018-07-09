using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using m = Model.MOCK;
namespace UnitTest
{
   [TestFixture]
    public class EmployeeTests
    {

        [Test]
        public void Testmethod()
        {
            var pfDetails = new m.EmpPfDetails(new m.EmpPersonalDetails());

            int employeeId = 1;
            var contrib = pfDetails.GetPfEmployerControlSofar(employeeId);
        }


    }
}
