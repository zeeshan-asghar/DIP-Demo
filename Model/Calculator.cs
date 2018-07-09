using System;

namespace Model
{
    public class Calculator //For unit testing
    {
        public int Subtract(int val1, int val2) => val1 - val2;

        public int Add(int val1, int val2)
        {
            return val1 + val2;
        }

        public int Multiply(int val1, int val2)
        {
            return val1 + val2;
        }

        public double Add(double val1, double val2) => val1 + val2;

        public double Divide(int val1, int val2)
        {
            if (val1 > 100)
                throw new ArgumentOutOfRangeException("by");

            return val1 / val2;
        }
    }
}