using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class BubbleSort
    {
        public static void Swape(int i, int j, int[] nums)
        {
            int temp = nums[j];
            nums[j] = nums[i];
            nums[i] = temp;
        }
        public static int[] BubbleSorts(int[] nums)
        {
            if (nums.Length == 0)
            {
                return new int[] { };
            }

            bool isSorted = false;
            int counter = 0;

            while (!isSorted)
            {
                isSorted = true;
                for (int i = 0; i < nums.Length - 1 - counter; i++)
                {
                    if (nums[i] > nums[i + 1])
                    {
                        Swape(i, i + 1, nums);
                        isSorted = false;
                    }
                }
                counter += 1;
            }

            return nums;
        }
    }
}
