﻿using System;
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
            int[] a =new int[] { 1, 2, 3, 7 ,5};
            Console.WriteLine(FindSubArray(12, a));
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
