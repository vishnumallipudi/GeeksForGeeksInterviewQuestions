using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //int ncases = int.Parse(Console.ReadLine());
            //var result = (Console.ReadLine()).Split(null);
            int[] a =new int[] { 0,1,2,1,0,0,0,1,0};
            var result=a.SorrtArrayZOT();
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
            
            Console.ReadLine();

        }

        private static int FindSubArray(int sum, int[] a)
        {
            int currentSum = a[0], start = 0;
            for (int i = 1; i < a.Length; i++)
            {
                if (currentSum==sum)
                {
                    //return from start...i-1
                    return currentSum;
                }
                if (currentSum<sum)
                {
                    currentSum += a[i];
                }
                if (currentSum+a[i]>sum)
                {
                    currentSum -= a[start];
                    currentSum += a[i];
                    start++;
                }
            }

            return 0;
        }
    }
}
