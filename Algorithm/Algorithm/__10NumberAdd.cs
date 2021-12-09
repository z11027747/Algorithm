using System.Collections.Generic;

namespace Algorithm
{
    public class __10NumberAdd
    {
        //无序的
        public static void BF()
        {
            //遍历两次
        }

        public static int[] BF2(int[] nums, int target)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (dictionary.TryGetValue(target - nums[i], out int index))
                {
                    return new int[] {i, index};
                }
                dictionary.Add(nums[i], i);
            }

            return new int[0];
        }

        //有序的
        public static int[] twoSearch(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                int low = i, high = nums.Length - 1;

                while (low <= high)
                {
                    int mid = low + (high - low) / 2;

                    if (nums[mid] == target - nums[i])
                    {
                        return new[] {i, mid};
                    }

                    if (nums[mid] < target - nums[i])
                    {
                        low = i;
                        high = mid - 1;
                    }
                    else if (nums[mid] > target - nums[i])
                    {
                        low = mid + 1;
                        high = nums.Length - 1;
                    }
                }
            }
            return new int[0];
        }

        public static int[] twoPoint(int[] nums, int target)
        {
            int low = 0;
            int high = nums.Length - 1;

            while (low <= high)
            {
                if (nums[low] + nums[high] == target)
                {
                    return new int[] {low, high};
                }

                if (nums[low] + nums[high] > target)
                {
                    high--;
                }
                else
                {
                    low++;
                }
            }

            return new int[0];
        }
    }
}