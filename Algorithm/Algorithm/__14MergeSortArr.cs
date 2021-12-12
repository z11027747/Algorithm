using System;

namespace Algorithm
{
    public class __14MergeSortArr
    {
        public static int[] BySystem(int[] nums1, int m, int[] nums2, int n)
        {
            Array.Copy(nums1, m, nums2, 0, n);
            Array.Sort(nums1);
            return nums1;
        }

        public static int[] TwoPoint(int[] nums1, int m, int[] nums2, int n)
        {
            int[] nums1_copy = new int[m];
            Array.Copy(nums1, 0, nums1_copy, 0, m);

            int p1 = 0; //nums1_copy
            int p2 = 0; //nums2
            int p = 0; //nums1

            while (p1 < m && p2 < n)
            {
                nums1[p++] = nums1_copy[p1] < nums2[p2] ? nums1_copy[p1++] : nums2[p2++];
            }

            if (p1 < m)
            {
                Array.Copy(nums1_copy, p1, nums1, p1 + p2, m + n - p1 - p2);
            }

            if (p2 < n)
            {
                Array.Copy(nums2, p2, nums1, p1 + p2, m + n - p1 - p2);
            }

            return nums1;
        }
    }
}