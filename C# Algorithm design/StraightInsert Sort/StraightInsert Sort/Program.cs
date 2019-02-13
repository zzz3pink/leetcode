using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StraightInsert_Sort
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] array = { 43, 69, 11, 72, 28, 21, 56, 80, 48, 94, 32, 8 };
            StraightInsertionSort(array);
            ShowSort(array);

            Console.ReadKey();
        }
        private static void ShowSort(int[] array)
        {
            foreach (var num in array)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();
        }
        public static void StraightInsertionSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {            
                int sentinel = array[i];
                int j = i - 1;

                while (j >= 0 && sentinel < array[j])
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = sentinel;
            }
        }
    }
}
