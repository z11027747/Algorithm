using System;

namespace Algorithm
{
    public class __15AvgArray
    {
        public static double FindMaxAverage(int[] nums, int k)
        {
            int sum = 0;
            int n = nums.Length;

            //统计第一个窗口的和
            for (int i = 0; i < k; i++)
            {
                sum += nums[i];
            }

            int max = sum;

            for (int i = k; i < n; i++)
            {
                sum -= nums[i - k];
                sum += nums[i];

                max = Math.Max(sum, max);
            }

            return max * 1.0 / k;
        }
    }
}