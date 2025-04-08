using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_21_01
{
    internal class DeleteDuplicates
    {


        public static void RemoveDuplicates(List<int> list)
        {
            HashSet<int> hash = new(list);
            List<int> newNumbers = new(hash);

            for (int i = 0; i < list.Count;)
            {
                if (i >= newNumbers.Count) list.RemoveAt(i);
                else
                {
                    list[i] = newNumbers[i];
                    i++;
                }
            }
        }
    }
}
