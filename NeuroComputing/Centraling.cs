using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuroComputing
{
    public static class Centraling
    {
        public static List<double> FindMeans(List<List<double>> values)
        {
            List<double> averages = new List<double>();
            int N = values[0].Count;
            for (int i = 0; i < N; i++)
            {
                double sum = 0;
                for(int j = 0; j < values.Count; j++)
                {
                    sum += values[j][i];
                }
                averages.Add(sum / values.Count);
            }
            return averages;
        }
        public static List<List<double>> Centre(List<List<double>> values, List<double>mean)
        {
            List<List<double>> result = new List<List<double>>();
            foreach (var value in values)
            {
                result.Add(Subtract(value, mean).ToList());
            }
            return result;
        }
        public static List<double> Subtract(List<double> value, List<double> mean)
        {
            List<double> values = new List<double>();            
            for(int i = 0; i < value.Count; i++)
            {
                values.Add(value[i] - mean[i]);
            }
            return values;
        }
    }
}
