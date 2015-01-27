using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAssArrayParam
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] dbl = { 3.2, 2.3, 6.5 };
            double average = CalculateAverage(dbl);
            Console.WriteLine("average is {0}", average);
            Console.ReadLine();
        }
        static double CalculateAverage(params double[] values)
        {
            double sum = 0;
            for (int i = 0; i < values.Length; i++)
            {
                sum += values[i];
            }

            return (sum / values.Length);
        }
    }
}
