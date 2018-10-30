using System;
using System.Collections.Generic;
using System.Text;

namespace TheTyrants
{
    public class Dice
    {
        private static Random rnd;

        static Dice()
        {
            rnd = new Random();
        }
        public static int ThrowDice(int min, int max)
        {
            int r1 = rnd.Next(min, max);

            return r1;
        }
    }
}
