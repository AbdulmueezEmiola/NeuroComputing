using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuroComputing
{
    public static class Shifting
    {
        public static IEnumerable<double> shift( List<double> arraySin, List<double> arrayCoSin, int n)
        {
            var result = arraySin.Skip(n).ToList();
            var lastValueSin = arraySin.Last();
            var lastValueCosin = arrayCoSin.Last();
            for(int i = 1; i <= n; i++)
            {
                double tempSum = (lastValueSin * arrayCoSin[i] + lastValueCosin * arraySin[i]);
                result.Add(tempSum);
            }
            return result;
        }

    }
}
