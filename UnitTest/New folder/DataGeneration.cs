using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    public class DataGeneratorForAdd
    {
        double[] Val1 = { 10, 20, 30 };
        double[] Val2 = { 10, 20, 30 };
        double[] expected = { 20, 40, 60 };
    }

    public class TestCaseData : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new[] { 15, 5, 10 };
            yield return new[] { 10, 20, 5 };
            yield return new[] { 100, 10, 90 };
        }
    }
}
