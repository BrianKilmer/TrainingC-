using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputParam
{
    class Program
    {
        static void Main(string[] args)
        {
            int ans;
            Add(10, 4, out ans);
            Console.WriteLine("adding 10 + 4 = {0}" , ans);

            Console.ReadLine();
        }

        static void Add(int x, int y, out int ans)
        {
            ans = x + y;
        }
    }
}
