using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            List<Mutant> mutants = new List<Mutant>();

            PsychicMutant m1 = new PsychicMutant();
            m1.CodeName = "Toad";
            m1.Level = 3;
            m1.IQ = 100;
            m1.PowerUsageCount = 2;
            mutants.Add(m1);

            PsychicMutant m2 = new PsychicMutant();
            m2.CodeName = "Frog";
            m2.Level =4;
            m2.IQ = 120;
            m2.PowerUsageCount = 1;
            mutants.Add(m2);


            PhysicalMutant p1 = new PhysicalMutant();
            p1.CodeName = "Strongman";
            p1.IQ = 80;
            p1.Level = 2;
            p1.Strength = 30;
            mutants.Add(p1);

            PhysicalMutant p2 = new PhysicalMutant();
            p2.CodeName = "Biggy";
            p2.IQ = 100;
            p2.Level = 3;
            p2.Strength = 20;
            mutants.Add(p2);

            ElementalMutant e1 = new ElementalMutant();
            e1.CodeName = "Dufas";
            e1.Level = 3;
            e1.Region = 3;
            mutants.Add(e1);

            ElementalMutant e2 = new ElementalMutant();
            e2.CodeName = "Simpleton";
            e2.Level = 5;
            e2.Region = 6;
            mutants.Add(e2);
             * */


            List<Mutant> mutants = new List<Mutant>() {
                new PhysicalMutant() { CodeName="MindBender", IQ=100,Level=3,Strength=10},
                new PhysicalMutant() { CodeName="Tester", IQ=120,Level=4,Strength=5},
                new PhysicalMutant() { CodeName = "BoobooHead", IQ = 70, Level = 2, Strength = 20 },
                new PhysicalMutant() { CodeName = "steelhead", IQ = 70, Level = 2, Strength = 20 },
                new ElementalMutant() { CodeName = "wad", Region = 70, Level = 2 },
                new ElementalMutant() { CodeName = "junkman", Region = 70, Level = 2 },
            };

            

            // generic type that we are setting our list to
            foreach (Mutant mutant in mutants)
            {
                mutant.DisplayInformation();
            }

            


            Console.ReadLine();
        }
    }
}
