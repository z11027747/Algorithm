namespace Algorithm
{
    public class _8Sqrt
    {
        public static void Bf(int x)
        {
            //2-根号x 遍历
            //i * i < x
            //i+1 * i+1 > x
        }

        public static int BinarySearch(int x)
        {
            int index = -1;

            int l = 0;
            int r = x;

            while (l < r)
            {
                int mid = l + (r - l) / 2;

                if (mid * mid > x)
                {
                    l = mid + 1;
                    r = x;
                }
                else
                {
                    index = mid;
                    l = 0;
                    r = mid - 1;
                }
            }

            return index;
        }

        public static int Newton(int x)
        {
            if (x == 0)
            {
                return 0;
            }
            return (int) Sqrt(x, x);
        }

        public static double Sqrt(double i, int x)
        {
            double res = (i + x / i) / 2;
            if (res == i)
            {
                return i;
            }
            else
            {
                return Sqrt(res, x);
            }
        }
    }
}