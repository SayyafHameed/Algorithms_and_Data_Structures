using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class InsertionSort
    {
        public static int[] InsertionSorts(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int j = i;
                while(j > 0 && arr[j] < arr[j - 1])
                {
                    Swape(j, j - 1, arr);
                    j--;
                }
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
