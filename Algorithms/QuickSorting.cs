using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class QuickSorting
    {
        public static int[] QuickSort(int[] array)
        {
            QuickSort(array, 0, array.Length - 1);
            return array;
        }

        public static void QuickSort(int[] array, int startIndex, int endIndex)
        {
            if (startIndex >= endIndex)
            {
                return;
            }

            int pivotIndex = startIndex;
            int leftIndex = startIndex + 1;
            int rightIndex = endIndex;

            while (rightIndex >= leftIndex)
            {
                if (array[leftIndex] > array[pivotIndex] && array[rightIndex] < array[pivotIndex])
                {
                    Swap(leftIndex, rightIndex, array);
                }
                if (array[leftIndex] < array[pivotIndex])
                {
                    leftIndex++;
                }
                if (array[rightIndex] > array[pivotIndex])
                {
                    rightIndex--;
                }
            }
            Swap(pivotIndex, rightIndex, array);

            bool isLeftSmaller = rightIndex - 1 - startIndex < endIndex - (rightIndex + 1);
            if (isLeftSmaller == true)
            {
                QuickSort(array, startIndex, rightIndex - 1);
                QuickSort(array, rightIndex + 1, endIndex);
            }
            else
            {
                QuickSort(array, rightIndex + 1, endIndex);
                QuickSort(array, startIndex, rightIndex - 1);
            }
        }

        static void Swap(int i, int j, int[] arr)
        {
            int temp = arr[j];
            arr[j] = arr[i];
            arr[i] = temp;
        }
    }
}
