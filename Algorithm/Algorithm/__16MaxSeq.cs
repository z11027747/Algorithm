using System;

namespace Algorithm
{
    public class __16MaxSeq
    {
        public static int FindLength(int[] nums)
        {
            int start = 0;
            int max = 0;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] <= nums[i - 1])
                {
                    start = i;
                }

                max = Math.Max(max, i - start + 1);
            }

            return max;
        }
    }
}