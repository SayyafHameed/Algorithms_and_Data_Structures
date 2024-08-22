using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class RadixSorting
    {
        public static int[] RadixSort(int[] nums)
        {
            if (nums.Length == 0)
            {
                return nums;
            }
            int maxNum = nums.Max();
            int digit = 0;

            while ((maxNum / (Math.Pow(10, digit)) > 0))
            {
                CountingSort(nums, digit);
                digit++;
            }
            return nums;
        }
  
        private static void CountingSort(int[] nums, int digit)
        {
            // initiate data Structures
            int[] counterArray = new int[10];
            int[] sortedArray = new int[nums.Length];

            // define digit column
            int digitColumn = (int)Math.Pow(10, digit);

            // populate count array
            foreach (var item in nums)
            {
                int countIndex = (item / digitColumn) % 10;
                counterArray[countIndex] += 1;
            }

            // update count array 
            for (int i = 1; i < counterArray.Length; i++)
            {
                counterArray[i] += counterArray[i - 1];
            }

            // populate sorted array
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                int countIndex = (nums[i] / digitColumn) % 10;
                counterArray[countIndex] -= 1;
                int sortedIndex = counterArray[countIndex];
                sortedArray[sortedIndex] = nums[i];
            }

            // copy sorted array to original array
            for (int i = 0; i < sortedArray.Length; i++)
            {
                nums[i] = sortedArray[i];
            }
        }
    }
}
