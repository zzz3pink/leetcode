using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection_Sort
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] array = { 43, 69, 11, 72, 28, 21, 56, 80, 48, 94, 32, 8 };

            SelectionSort(array);
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

        public static void SelectionSort(int[] array)
        {
            int swap;
            int pos = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                pos = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if(array[j]<array[pos])
                    {
                        pos = j;
                    }
                }
                swap = array[pos];
                array[pos] = array[i];
                array[i] = swap;
            }
        }
    }
}
