using System;

namespace Algorithm
{
    public class _9MaxValue
    {
        public static void Bf(int[] nums)
        {
            //+ max3
            //- max3
            //+-  min2*min1*max

            Array.Sort(nums);

            int n = nums.Length;
            int maxValue = Math.Max(nums[0] * nums[1] * nums[n - 1], nums[n - 1] * nums[n - 2] * nums[n - 3]);
        }

        public static void LinkScan(int[] nums)
        {
            int min1 = int.MaxValue;
            int min2 = int.MaxValue;
            int max1 = int.MinValue;
            int max2 = int.MinValue;
            int max3 = int.MinValue;

            for (int i = 0; i < nums.Length; i++)
            {
                if (i < min1)
                {
                    min2 = min1;
                    min1 = i;
                }
                else if (i < min2)
                {
                    min2 = i;
                }

                if (i > max1)
                {
                    max3 = max2;
                    max2 = max1;
                    max1 = i;
                }
                else if (i > max2)
                {
                    max2 = max1;
                    max1 = i;
                }
                else if (i > max3)
                {
                    max1 = i;
                }
            }

            int maxValue = Math.Max(min1 * min2 * max1, max1 * max2 * max3);
        }
    }
}