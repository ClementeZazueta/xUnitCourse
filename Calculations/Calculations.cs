using System;
using System.Collections.Generic;
using System.Text;

namespace Calculations
{
    public class Calculations
    {
        public List<int> FibonacciNumbers => new List<int> { 1, 1, 2, 3, 5, 8, 13 };

        public bool IsOdd(int value)
        {
            return value % 2 == 1;
        }
    }
}
