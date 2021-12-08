namespace Algorithm
{
    public class _3PrimeNumber
    {
        public static int Bf(int n)
        {
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                count += IsPrime(i) ? 1 : 0;
            }
            return count;
        }

        private static bool IsPrime(int n)
        {
            for (int i = 2; i * i <= n; i++) //num 可以是根号X
            {
                if (n % i != 0)
                    return false;
            }
            return true;
        }

        public static int Eratosthenes(int n)
        {
            bool[] isPrime = new bool[n];

            int count = 0;
            for (int i = 2; i < n; i++)
            {
                if (!isPrime[i])
                {
                    count++;
                    for (int j = 2 * i; j < n; j += i)
                    {
                        isPrime[j] = true;
                    }
                }
            }

            return count;
        }
    }
}