using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuroComputing
{
    public static class Covariance
    {
        public static double FindCovariance(List<double> values1, List<double> values2)
        {
            int n = values1.Count;
            double value = 0;
            var mean1 = values1.Average();
            var mean2 = values2.Average();
            for (int i = 0; i < n; i++)
            {
                value += (values1[i] - mean1) * (values2[i] - mean2);
            }
            return value / n;
        }
    }
}
