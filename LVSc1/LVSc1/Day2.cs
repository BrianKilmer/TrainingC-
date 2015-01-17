using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LVSc1
{
    class Day2
    {
        static void Main(string[] args)
        {
            //int x = 3;
            //int y = 2;
            //string message = (x > y)?"bob":"car";
            //string x = "3";
            //string message = "";
            //switch (x)
            //{
            //    case "1":  case "3":
            //        message = "yes 1 or 3";
            //            break;
            //    default:
            //            message = "no 1";
            //        break;
            //}
            //Console.WriteLine(message);
            
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("hi");
            //}

            StreamReader myreader = new StreamReader("TextFile1.txt");
            string line = "";
            string holdline = "";

            while (line != null)
            {
                line = myreader.ReadLine();
                if (line != null)
                    holdline += line + ' ';

            }
            holdline = holdline.Trim();
            char[] charArray = holdline.ToCharArray();
            Array.Reverse(charArray);

            
            myreader.Close();

            Console.WriteLine(charArray);

            using (StreamWriter writer = new StreamWriter("Newfile.txt",true))
            {
                writer.WriteLine(charArray);
                writer.WriteLine("new line2");
                writer.Close();
            }
            

            //int[] nums = new int[5];
            //nums[0] = 4;
            //nums[1] = 22;
            //nums[2] = 3;
            //nums[3] = 44;
            //nums[4] = 5;

            //int[] nums = { 4, 5, 33, 44, 55 };

            //foreach (var item in nums)
            //{
            //    Console.WriteLine(item);
            //}

            //string myTxt = "this is easy so far";
            //char[] charArray = myTxt.ToCharArray();
            //Array.Reverse(charArray);
            //Console.WriteLine(charArray);

            Console.ReadLine();
        }
     }
}
