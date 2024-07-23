using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class SelectionSorts
    {
        public static int[] SelectionSort(int[] arr)
        {
            int startIndex = 0;
            while (startIndex < arr.Length - 1)
            {
                int smallNum = startIndex;
                for (int i = startIndex + 1; i < arr.Length; i++)
                {
                    if (arr[smallNum] > arr[i])
                    {
                        smallNum = i;
                    }
                }
                Swape(startIndex, smallNum, arr);
                startIndex++;
            }
            return arr;

        }

        static void Swape(int i, int j, int[] arr)
        {
            int temp = arr[j];
            arr[j] = arr[i];
            arr[i] = temp;
        }
    }
}
