using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add("1");
            list.Add(2);
            list.Add("3");
            list.Add('4');
            foreach (object s in list)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("=============================");
//--------------------------------------------------------
            List<string> listOfStrings = new List<string>();
            listOfStrings.Add("one");
            listOfStrings.Add("two");
            listOfStrings.Add("three");
            listOfStrings.Add("four");

            foreach (string s in listOfStrings)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("=============================");
//--------------------------------------------------------
            Console.WriteLine(SimpleReturn()); //will only return the first return from the method
            Console.WriteLine(SimpleReturn());
            Console.WriteLine(SimpleReturn());
            Console.WriteLine(SimpleReturn());
            Console.WriteLine("=============================");
//--------------------------------------------------------
            foreach (int i in YieldReturn())
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("=============================");
//--------------------------------------------------------
            MyArrayList myList = new MyArrayList();

            myList.Add("1");
            myList.Add(2);
            myList.Add("3");
            myList.Add('4');

            foreach (object s in myList)
            {
                Console.WriteLine(s);
            }
//--------------------------------------------------------
//--------------------------------------------------------
//--------------------------------------------------------
            Console.ReadLine();
        }
        static int SimpleReturn()
        {
            return 1;
            return 2;
            return 3;
        }

        static IEnumerable<int> YieldReturn()
        {
            yield return 1;
            yield return 2;
            yield return 3;
            yield return 73;
        }
    }

    
}
