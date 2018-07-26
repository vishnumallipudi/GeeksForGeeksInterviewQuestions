using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public static class LeadersInAArray
    {
        public static void LeadersInArray(this int[] a)
        {
            int rightmax = a[a.Length-1];
            for (int i = a.Length - 1; i >= 0; i--)
            {
                if (a[i]>=rightmax)
                {
                    rightmax = a[i];
                    Console.WriteLine(a[i]);
                }
            }
        }
    }
}
