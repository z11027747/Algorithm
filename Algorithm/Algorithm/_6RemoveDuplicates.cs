namespace Algorithm
{
    public class _6RemoveDuplicates
    {
        public static int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }

            int i = 0;
            int j = 1;

            while (j < nums.Length)
            {
                if (nums[i] != nums[j])
                {
                    i++;
                    j++;
                    nums[i + 1] = nums[j];
                }
                else
                {
                    j++;
                }
            }

            return i;
        }
    }
}