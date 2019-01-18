using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quick_Sort
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] array = { 43, 69, 51, 32, 5, 7, 26 };
            QuickSort(array, 0, array.Length - 1);
            ShowArray(array);

            Console.ReadKey();
        }

        public static void ShowArray(int[] array)
        {
            foreach (var num in array)
            {
                Console.WriteLine($"{num}");
            }
        }

        public static void QuickSort(int[] array, int left, int right)
        {
            if(left < right)
            {
                int i = left, j = right;
                int pivot = array[i];

                while (i<j)
                {
                    while (i < j && array[j] >= pivot) { j--; }
                    array[i] = array[j];

                    while (i < j && array[i] <= pivot) { i++; }
                    array[j] = array[i];
                }

                array[i] = pivot;
                QuickSort(array, left, i - 1);
                QuickSort(array, i + 1, right);
            }
        }
    }
}
