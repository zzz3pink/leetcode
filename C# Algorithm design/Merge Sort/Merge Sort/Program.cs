using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//分治算法  Divide and Conquer 
namespace Merge_Sort
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] array = { 43, 69, 11, 72, 56, 24, 5, 3, 7 };

            MergeSort(array, 0, array.Length - 1);
            ShowSort(array);

            Console.ReadKey();
        }

        private static void ShowSort(int[] array)
        {
            foreach(var num in array)
            {
                Console.Write($"{num} ");
            }

            Console.WriteLine();
        }

        public static void MergeSort(int[] array, int low, int high)
        {

        }
    }
}
