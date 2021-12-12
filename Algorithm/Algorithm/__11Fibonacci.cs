namespace Algorithm
{
    public class __11Fibonacci
    {
        public static int Bf(int n)
        {
            if (n == 0)
            {
                return 0;
            }

            if (n == 1)
            {
                return 1;
            }

            return Bf(n - 1) + Bf(n - 2);
        }

        public static int Recurse(int[] arr, int n)
        {
            if (n == 0)
            {
                return 0;
            }

            if (n == 1)
            {
                return 1;
            }

            if (arr[n] != 0)
            {
                return arr[n];
            }

            arr[n] = Bf(n - 1) + Bf(n - 2);

            return arr[n];
        }
    }
}