using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_9
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] countries = { "USA", "China", "UK", "German", "Mexico", "Uganda", "Italy", "Australia", "Spain", "Sweden" };

            //foreach (string country in countries)
            //{
            //    if (country.StartsWith("U"))
            //    {
            //        Console.WriteLine(country);
            //    }
            //}

            //var ucountries = from c in countries
            //                    where c.StartsWith("U")
            //                    select c;

            //foreach (string country in ucountries)
            //{
            //    Console.WriteLine(country);
            //}
            ////----------
            //// Method syntax
            //var uCountries = countries.Where(p => p.StartsWith("U"));
            //foreach (string country in uCountries)
            //    Console.WriteLine(country);
            ////----------
            //foreach (string country in  countries.Where(p => p.StartsWith("U")))
            //    Console.WriteLine(country);
            ////----------
            //foreach (string country in countries.Where(p => p.Length > 5))
            //    Console.WriteLine(country);
            ////----------
            //foreach (string country in countries.OrderBy(p => p))
            //        Console.WriteLine(country);
            ////----------
            //foreach (string country in countries.OrderByDescending(p => p))
            //    Console.WriteLine(country);
            ////----------
            //foreach (string country in countries.Skip(2))
            //    Console.WriteLine(country);
            ////----------
            //foreach (string country in countries.Take(2))
            //    Console.WriteLine(country);
            ////----------
            //    //&& jopining conditions
            //var uCountries = from country in countries
            //                    where country.StartsWith("U")
            //                    && country.Length > 5
            //                    select country;

            //    //or..
            //var MyCounties = countries.Where(p => p.StartsWith("U") && p.Length > 5);
            //foreach (string country in MyCounties)
            //    Console.WriteLine(country);
            //----------
            //var uCountries = from country in countries
            //                    orderby country descending
            //                    select country;

            var MyCounties = countries.OrderBy(p => p);

            foreach (string country in MyCounties)
                Console.WriteLine(country);
            //----------
           
            Console.ReadLine();
        }
    }
}
