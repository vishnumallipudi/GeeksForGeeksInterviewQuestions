using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    //https://practice.geeksforgeeks.org/problems/subarray-with-given-sum/0
    class SubArrayWithGivenSum
    {
        private static int FindSubArray(int sum, int[] a)
        {
            int currentSum = a[0], start = 0;
            for (int i = 1; i < a.Length; i++)
            {
                if (currentSum == sum)
                {
                    //return from start...i-1
                    return currentSum;
                }
                if (currentSum < sum)
                {
                    currentSum += a[i];
                }
                if (currentSum + a[i] > sum)
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
