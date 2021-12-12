namespace Algorithm
{
    public class __12ArrangeCoin
    {
        public static int BF(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                n = n - i;
                if (n <= i)
                {
                    return i;
                }
            }

            return 0;
        }

        public static int BinarySearch(int n)
        {
            int low = 0;
            int high = n;

            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                
                int cost = ((mid + 1) * mid) / 2;
                
                if (cost == n)
                {
                    return mid;
                }
                else if (cost < n)
                {
                    low = 0;
                    high = mid - 1;
                }
                else if (cost > n)
                {
                    low = mid + 1;
                    high = n;
                }
            }

            return high;
        }
        
        
        
    }
}