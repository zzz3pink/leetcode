using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//a.将无序序列构建成一个堆,大顶堆
//b.将堆顶元素和末尾元素交换，将最大元素沉到数组末端
//c.重新调整结构，使其满足堆定义，然后继续交换堆顶元素和当前末尾元素。递归
namespace Heap_Sort
{
    class Program
    {
       public static void Main(string[] args)
        {
            int[] array = { 10, 24, 5, 3, 7, 12 };
            HeapSort(array);
            ShowSort(array);

            Console.ReadKey();
        }

        private static void ShowSort(int[] array) 
        {
            foreach (var num in array)
            {
                Console.Write($"{num} ");
            }
        }

        private static void HeapSort(int[] array)
        {
            MaxHeap(array);
            for (int i = array.Length - 1; i > 0; i--)
            {
                Swap(ref array[0], ref array[i]);
                Heapify(array, 0, i);
            }
        }

        private static void MaxHeap(int[] array)
        {
            for (int i = array.Length / 2 - 1; i >= 0; i--)
            {
                Heapify(array, i, array.Length);
            }
        }

        private static void Heapify(int[] array, int index, int size)
        {
            int left = 2 * index + 1;
            int right = 2 * index + 2;
            int large = index;

            if (left < size && array[left] > array[large])
            {
                large = left;
            }
            if (right < size && array[right] > array[large])
            {
                large = right;
            }

            if(index!=large)
            {
                Swap(ref array[index], ref array[large]);
                Heapify(array, large, size);
            }
        }

        private static void Swap(ref int first, ref int second)
        {
            int t = first;
            first = second;
            second = t;
        }
    }
}
