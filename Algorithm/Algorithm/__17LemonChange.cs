namespace Algorithm
{
    public class __17LemonChange
    {
        //贪心：局部最优

        public static bool Change(int[] bills)
        {
            int five = 0;
            int ten = 0;

            for (int i = 0; i < bills.Length; i++)
            {
                if (bills[i] == 5)
                {
                    five++;
                }
                else if (bills[i] == 10)
                {
                    if (five == 0)
                        return false;
                    five--;
                    ten++;
                }
                else if (bills[i] == 20)
                {
                    if (five > 0 && ten > 0)
                    {
                        five--;
                        ten--;
                    }
                    else if (five >= 3)
                    {
                        five -= 3;
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}