using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble_Sort
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 43, 69, 11, 72, 56, 24, 5, 3, 7 };
            BubbleSort(array);
            ShowSord(array);

            Console.ReadKey();
            Console.ReadLine();
        }

        static void ShowSord(int[] array)
        {
            foreach (var num in array)
            {
                Console.Write($"{num} ");
            }
        }

        static void BubbleSort(int[] array)
        {
            int swap;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1]) 
                    {
                        swap = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = swap;
                    }
                }
            }

        }
    }
}
