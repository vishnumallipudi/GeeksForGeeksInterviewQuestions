using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
   public static class DutchNationalFlagProblem
    {
        public static int[] SorrtArrayZOT(this int[] a)
        {
            int mid = 0;
            int low = 0;
            int high = a.Length-1;
            while (mid < a.Length-1)
            {
                if (a[mid] == 2)
                {
                    //swap a[mid], a[high]
                    int temp = a[mid];
                    a[mid] = a[high];
                    a[high] = temp;
                    high--;
                }
                else if (a[mid] == 0)
                {
                    //swap a[mid], a[high]
                    int temp = a[mid];
                    a[mid] = a[low];
                    a[low] = temp;
                    low++;
                    mid++;
                }
               else if (a[mid] == 1)
                {
                    mid++;
                }
            }
            return a;
        }
    }
}
