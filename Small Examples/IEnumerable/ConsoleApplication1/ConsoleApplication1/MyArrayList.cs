using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class MyArrayList : IEnumerable
    {
        object[] m_Items = null;
        int freeIndex = 0;

        //constructor
        public MyArrayList()
        {
            // For the sake of simplicity lets keep them as arrays
            // ideally it should be link list
            m_Items = new object[100];
        }

        public void Add(object item)
        {
            // Let us only worry about adding the item 
            m_Items[freeIndex] = item;
            freeIndex++;
        }

        // IEnumerable Member
        public IEnumerator GetEnumerator()
        {
            foreach (object o in m_Items)
            {
                // Lets check for end of list (its bad code since we used arrays)
                if (o == null)
                {
                    break;
                }

                // Return the current element and then on next function call 
                // resume from next element rather than starting all over again;
                yield return o;
            }
        }
    }
}
