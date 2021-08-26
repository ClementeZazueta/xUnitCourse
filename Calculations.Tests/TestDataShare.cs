using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations.Tests
{
    public static class TestDataShare
    {
        public static IEnumerable<object[]> IsOddOrEvenParameterValues
        {
            get
            {
                yield return new object[] { 1, true };
                yield return new object[] { 2, false};
            }
        }

        public static IEnumerable<object[]> IsOddOrEvenExternalData
        {
            get
            {
                var readAllLines = System.IO.File.ReadAllLines("IsOddOrEvenTestData.txt");
                return readAllLines.Select(l =>
                {
                    var lineSplit = l.Split(',');
                    return new object[] { int.Parse(lineSplit[0]), bool.Parse(lineSplit[1]) };
                });
            }
        }
    }
}
