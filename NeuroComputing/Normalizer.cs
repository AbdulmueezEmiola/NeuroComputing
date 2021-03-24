using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuroComputing
{
    public class Normalizer
    {
        public double Reference  { get; set; }
        public Normalizer(List<double> reference)
        {
            Reference = reference.Select(x=>x*x).Sum();
        }
        public List<double> Normalize(List<double>values)
        {
            double sum = values.Select(x => x * x).Sum();
            List<double> result = new List<double>();
            result = values.Select(x => x*Math.Sqrt(Reference / sum)).ToList();
            return result;
        }
    }
}
