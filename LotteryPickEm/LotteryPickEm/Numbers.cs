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
        static Random rand = new Random();

        public static List<int> GetNumbers()
        {
            List<int> numbers = new List<int>();
            int temp;

            for (int i = 0; i < 6;)
            {
                temp = numbers.Count <= 4 ? rand.Next(MAX_WHITE_BALL) : rand.Next(MAX_RED_BALL);

                //the or numbers.count == 5 is because they pick the power ball from
                //a seperate bin so it can repeat a previous number
                if (!numbers.Contains(temp) || numbers.Count == 5)
                {
                    i++;
                    numbers.Add(temp);
                }
            }
            return numbers;
        }
    }
}
