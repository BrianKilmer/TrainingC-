using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            mgr m = mgr.m2;
            Ask(m);
            Console.ReadLine();
        }

        enum mgr
        {
            m1,
            m2,
            m3
        }

        static void Ask(mgr e)
        {
            switch (e)
            {
                case mgr.m1:
                    Console.WriteLine("M1 says this");
                    break;
                case mgr.m2:
                    Console.WriteLine("M2 says this");
                    break;
                case mgr.m3:
                    Console.WriteLine("M3 says this");
                    break;
            }
        }
    }
}
