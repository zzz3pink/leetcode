using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Find the median of the two sorted arrays.
//nums1 = [1, 2]
//nums2 = [3, 4]
//中位数是(2 + 3)/2 = 2.5

namespace _4.Median_of_Two_Sorted_Arrays
{
    class Program
    {
        private static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int size = nums1.Length + nums2.Length;
            int[] union = new int[size];
            int mid = size / 2;
            int even = (size % 2 == 0) ? 1 : 0;

            int m1, m2;
            int left, right;

            for (int i = m1 = m2 = 0; i < size; i++)
            {
                left = m1 < nums1.Length ? nums1[m1] : int.MaxValue;
                right = m2 < nums2.Length ? nums2[m2] : int.MaxValue;

                if(left<right)
                {
                    union[m1 + m2] = nums1[m1];
                    m1++;
                }
                else
                {
                    union[m1 + m2] = nums2[m2];
                    m2++;
                }

                if (i == mid)
                    break;
            }
            return (union[mid] + union[mid - even]) / 2.0;
        }

        static void Main(string[] args)
        {
            int[] nums1 = { 1, 2, 3 };
            int[] nums2 = { 4, 5 };

            var res = FindMedianSortedArrays(nums1, nums2);

            Console.WriteLine($"The median is {res}.");
            Console.ReadKey();
        }
    }
}
