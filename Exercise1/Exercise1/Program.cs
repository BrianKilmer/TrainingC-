using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {

            //ex1-------------------------------------
            //using (SqlConnection myConnection = new SqlConnection("data source=db-dev;initial catalog=print;integrated security=True;User ID=iusr_print_sq;Password=Dasesa809"))
            //{

            //    myConnection.Open();
            //    SqlCommand mycommand = myConnection.CreateCommand();
            //    mycommand.CommandText = "select count(*) from product";
            //    mycommand.CommandType = System.Data.CommandType.Text;

            //    Int32 count = (Int32)mycommand.ExecuteScalar();

            //    Console.WriteLine("There are {0} products in the databse.", count);
            //    Console.ReadLine();

            //    //myConnection.Close();
            //}

            //ex2-------------------------------------

            DateTime firstDay = DateTime.Parse("1/1/2015");
            DateTime lastDay = DateTime.Parse("5/31/2015");
            TimeSpan t = lastDay - firstDay;
            double NumDays = t.TotalDays;

            DateTime[] vacationDay = new DateTime[4];
            vacationDay[0] = DateTime.Parse("1/3/15");
            vacationDay[1] = DateTime.Parse("5/3/15");
            vacationDay[2] = DateTime.Parse("11/26/15");
            vacationDay[3] = DateTime.Parse("11/27/15");

            bool matched = false;

            for (int i = 0; i < NumDays; i++)
            {
                foreach (var item in vacationDay)
                {
                    if (item == firstDay.AddDays(i))
                        matched = true;
                }
                if (!matched)
                    Console.WriteLine(firstDay.AddDays(i).ToShortDateString());

                matched = false;
            }


            Console.WriteLine();

           //ex3 -------------------------------------
            //Print out a count of each distinct character from an input string, sorted by count

            Console.WriteLine("Type in a string and hit enter...");
            string str = Console.ReadLine();

            //while (str.Length > 0)
            // {
            //     Console.Write(str[0] + " : ");
            //     int count = 0;
            //     for (int j = 0; j < str.Length; j++)
            //     {
            //         if (str[0] == str[j])
            //         {
            //             count++;
            //         }
            //     }
            //     Console.WriteLine(count); 
            //     str = str.Replace(str[0].ToString(),string.Empty);  
            // }
            // Console.ReadLine();

       


             Console.WriteLine();
             Console.WriteLine("=======================");
             Console.WriteLine();
            

            var x = (from c in str.ToLower()
                    group c by c into a
                    select new 
                    { 
                        a.Key, Count = a.Count() 
                    }).OrderByDescending(y => y.Count)
                    
                    ;

            foreach (var thing in x)
            {
                if (Convert.ToString(thing.Key) != " ")
                {
                   Console.WriteLine("{0} : {1}", thing.Key, thing.Count); 
                }
                
            }



            Console.ReadLine();

           

        }
    }
}
