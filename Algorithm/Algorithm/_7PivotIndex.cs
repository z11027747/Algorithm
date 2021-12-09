using System.Linq;

namespace Algorithm
{
    public class _7PivotIndex
    {
        public static int PivotIndex(int[] nums)
        {
            int sum = nums.Sum(item => item);

            int total = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                total += nums[i];

                if (total == sum)
                {
                    return i;
                }

                sum -= nums[i];
            }

            return -1;
        }
    }
}