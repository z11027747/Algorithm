namespace Algorithm
{
    public class _4StringSearch
    {
        //IndexOf

        public static void Bf(string input)
        {
            //逐个比较
        }

        public static void RK(string input)
        {
            //A=1 b=2 c=3  
            //当钱子串hash值是前一个子串的减去最小值，加上最大值
            // 还需要考虑Hash冲突问题
        }

        public static void BM(string input)
        {
            //从后往前匹配，如果遇到失败 就继续向前找，整体移动

            //可以选一个错误的
            //也可以选一组正确的
        }

        public static int KMP(string input, string pattern, int[] next)
        {
            int i = 0;
            int j = 0;

            while (i < input.Length && j < pattern.Length)
            {
                if (j == -1 || input[i] == pattern[i])
                {
                    i++;
                    j++;
                }
                else
                {
                    j = next[j];
                }
            }

            if (j == pattern.Length)
            {
                return i - j;
            }
            return -1;
        }

        //A,B,C,A,B,C,A,A,A,B,C,A,B,C,D
        //                A,B,C,A,B,C,D
        //            A,B,C,A,B,C,D
        //x,0,0,1,2,3,0

        public static void GetNext(string pattern, int[] next)
        {
            next[0] = -1;
            int i = 0, j = -1;

            while (i < pattern.Length)
            {
                if (j == -1)
                {
                    i++;
                    j++;
                }
                else if (pattern[i] == pattern[j])
                {
                    i++;
                    j++;
                    next[i] = j;
                }
                else
                {
                    j = next[j];
                }
            }
        }
    }
}