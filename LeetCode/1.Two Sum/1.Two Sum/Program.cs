using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Given an array of integers, return indices of the two numbers such that they add up to a specific target.
//You may assume that each input would have exactly one solution, and you may not use the same element twice.
//Example:
//Given nums = [2, 7, 11, 15], target = 9,
//Because nums[0] + nums[1] = 2 + 7 = 9,
//return [0, 1].

namespace _1.Two_Sum
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] nums = { 2, 8, 7, 11, 15 };

            var res = TwoSum(nums, 9);
            var res2 = TwoSum2(nums, 9);

            Console.WriteLine($"[{res[0]},{res[1]}]");
            Console.WriteLine($"[{res2[0]},{res2[1]}]");

            Console.ReadKey();
        }

        public static int[] TwoSum(int[] nums, int targaet)
        {
            for(int i=0; i<nums.Length;i++)
            {
                for(int j=i+1;j<nums.Length;j++)
                {
                    if(nums[i]+nums[j]==targaet)
                    {
                        return new int[] { i, j };
                    }
                }
            }

            throw new ArgumentException();
        }
        public static int[] TwoSum2(int[] nums, int targaet)
        {
            var dictionary = new Dictionary<int, int>();

            for(int i=0;i<nums.Length;i++)
            {
                int complement = targaet - nums[i];

                if(dictionary.ContainsKey(complement))
                {
                    return new int[] { dictionary[complement], i };
                }
                //Give key nums[i], value i.
                dictionary[nums[i]] = i;
            }
            throw new ArgumentException();
        }
    }
}
