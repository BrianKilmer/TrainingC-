using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Program
    {
        static void Main(string[] args)
        {
            Personnel p = new Personnel("Brian", "North America", "Spy", "CIA", "Steve Correl");
            Analyzer.Analyze(p);

            Agent a = new Agent();
            a.CodeName = "fred";
            a.Region = "Russia";
            a.SkillSet = "Secret Spy";
            Analyzer.Analyze(a);
          
            Console.ReadLine();
        }
    }
}
