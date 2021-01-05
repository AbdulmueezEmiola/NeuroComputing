using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuroComputing
{
    public static class Centraling
    {        
        public static List<List<double>> Centre(List<List<double>> values)
        {
            List<List<double>> result = new List<List<double>>();
            foreach (var value in values)
            {
                double average = value.Average();
                result.Add(value.Select(x => x - average).ToList());
                
            }
            return result;
        }
        public static List<double> Centre(List<double> values)
        {
            
            double average = values.Average();
            return values.Select(x => x - average).ToList();
        }
    }
}
