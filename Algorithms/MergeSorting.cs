using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class MergeSorting
    {
        // Index  0  1  2  3  4  5  6
        // Array [8, 5, 2, 5, 9, 6, 3]
        //        i              j
        // used Divide and Conquer in Merge Algorithms
        // left [8, 5, 2, 5]      right [9, 6, 3]
        //      [8, 5]  [2, 5]          [9, 6]  [3]    
        //      [8] [5] [2] [5]         [9] [6]  [3]
        // k = [2, 5, 5, 8]             [3, 6, 9]
        // used pointer  i                     j
        // k = [2, 3, 5, 5, 6, 8, 9]

        // Time complexity   o(n log(n))
        // Space complexity  o(n)

        public static int[] MergeSort(int[] arr)
        {
            if(arr.Length <= 1)
            {
                return arr;
            }
            int midIndex = arr.Length / 2;

            int[] leftSub = arr.Take(midIndex).ToArray();
            int[] rightSub = arr.Skip(midIndex).ToArray();

            return SortArrays(MergeSort(leftSub), MergeSort(rightSub));
        }

        public static int[] SortArrays(int[] left, int[] right)
        {
            int[] sortedArray = new int[left.Length + right.Length];
            int i = 0;
            int j = 0;
            int k = 0;
            while (i < left.Length && j < right.Length)
            {
                if (left[i] <= right[j])
                {
                    sortedArray[k++] = left[i++];
                }
                else
                {
                    sortedArray[k++] = right[j++];
                }
            }
            while (i < left.Length)
            {
                sortedArray[k++] = left[i++];
            }
            while(j < right.Length)
            {
                sortedArray[k++] = right[j++];
            }

            return sortedArray;
        }
    }
}
