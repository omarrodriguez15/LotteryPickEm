using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotteryPickEm
{
    public static class Numbers
    {
        const int MAX_WHITE_BALL = 69;
        const int MAX_RED_BALL = 26;

        public static List<int> GetNumbers()
        {
            List<int> numbers = new List<int>();
            Random rand = new Random();
            int temp;

            for (int i = 0; i < 6;)
            {
                if (numbers.Count <= 5)
                {
                    temp = rand.Next(MAX_RED_BALL);

                    if (!numbers.Contains(temp))
                    {
                        i++;
                        //pass in max number for random to reurn
                        numbers.Add(temp);
                    }
                }
                else if (numbers.Count == 6)
                {
                    numbers.Add(rand.Next(MAX_WHITE_BALL));
                }
            }
            return numbers;
        }
    }
}
