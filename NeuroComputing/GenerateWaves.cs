using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuroComputing
{
    static class GenerateWaves
    {
        public static List<double> GenerateSinusoid(int N, double x)
        {
            List<double> values = new List<double>();
            for (int n = 0; n < N; n++)
            {
                var value = Math.Sin(n * x * 2 * Math.PI / N);
                values.Add(value);
            }
            return values;
        }
        public static List<double> GenerateCosinusoid(int N, double x)
        {
            List<double> values = new List<double>();
            for (int n = 0; n < N; n++)
            {
                var value = Math.Cos(n * x * 2 * Math.PI / N);
                values.Add(value);
            }
            return values;
        }
    }
}