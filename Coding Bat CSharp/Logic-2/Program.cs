using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_2
{
    class Program
    {
        static void Main(string[] args)
        {
 
            Console.WriteLine("makeBricks");
            Console.WriteLine(makeBricks(3, 1, 8) == true);
            Console.WriteLine(makeBricks(3, 1, 9) == false);
            Console.WriteLine(makeBricks(3, 2, 10) == true);
   
            Console.WriteLine("loneSum");
            Console.WriteLine(loneSum(1, 2, 3) == 6);
            Console.WriteLine(loneSum(3, 2, 3) == 2);
            Console.WriteLine(loneSum(3, 3, 3) == 0);

            Console.WriteLine("luckySum");
            Console.WriteLine(luckySum(1, 2, 3) == 6);
            Console.WriteLine(luckySum(1, 2, 13) == 3);
            Console.WriteLine(luckySum(1, 13, 3) == 1);

            Console.WriteLine("luckySumLinq");
            Console.WriteLine(luckySumLinq(1, 2, 3) == 6);
            Console.WriteLine(luckySumLinq(1, 2, 13) == 3);
            Console.WriteLine(luckySumLinq(1, 13, 3) == 1);

            Console.WriteLine("noTeenSum");
            Console.WriteLine(noTeenSum(1, 2, 3) == 6);
            Console.WriteLine(noTeenSum(2, 13, 1) == 3);
            Console.WriteLine(noTeenSum(2, 1, 14) == 3);

            Console.WriteLine("noTeenSum");
            Console.WriteLine(noTeenSumLinq(1, 2, 3) == 6);
            Console.WriteLine(noTeenSumLinq(2, 13, 1) == 3);
            Console.WriteLine(noTeenSumLinq(2, 1, 14) == 3);

            Console.WriteLine("roundSum");
            Console.WriteLine(roundSum(16, 17, 18) == 60);
            Console.WriteLine(roundSum(12, 13, 14) == 30);
            Console.WriteLine(roundSum(6, 4, 4) == 10);
            
            Console.WriteLine("closeFar");
            Console.WriteLine(closeFar(1, 2, 10, 20) == true);
            Console.WriteLine(closeFar(1, 2, 3, 4) == false);
            Console.WriteLine(closeFar(1, 2, 10, 0) == false);
            
            Console.WriteLine("blackjack");
            Console.WriteLine(blackjack(21, 20, 21) == 21);
            Console.WriteLine(blackjack(21, 21, 20) == 21);
            Console.WriteLine(blackjack(21, 21, 22) == 21);
            Console.WriteLine(blackjack(21, 22, 21) == 21);
            Console.WriteLine(blackjack(21, 22, 23) == 0);

            Console.WriteLine("blackjackLinq");
            Console.WriteLine(blackjackLinq(21, 20, 21) == 21);
            Console.WriteLine(blackjackLinq(21, 21, 20) == 21);
            Console.WriteLine(blackjackLinq(21, 21, 22) == 21);
            Console.WriteLine(blackjackLinq(21, 22, 21) == 21);
            Console.WriteLine(blackjackLinq(21, 22, 23) == 0);

            Console.WriteLine("evenlySpaced");
            Console.WriteLine(evenlySpaced(2, 4, 6) == true);
            Console.WriteLine(evenlySpaced(4, 6, 2) == true);
            Console.WriteLine(evenlySpaced(4, 6, 3) == false);

            Console.WriteLine("makeChocolate");
            Console.WriteLine(makeChocolate(4, 1, 9) == 4);
            Console.WriteLine(makeChocolate(4, 1, 10) == -1);
            Console.WriteLine(makeChocolate(4, 1, 7) == 2);

        }


        /*
        We want to make a row of bricks that is goal inches long. 
        We have a number of small bricks (1 inch each) and big bricks (5 inches each). 
        Return true if it is possible to make the goal by choosing from the given bricks. 
        This is a little harder than it looks and can be done without any loops. 

        makeBricks(3, 1, 8) → true
        makeBricks(3, 1, 9) → false
        makeBricks(3, 2, 10) → true
        */
        public static bool makeBricks(int small, int big, int goal)
        {
            return 5 * big + small >= goal && small >= goal % 5;
        }

        /*
        Given integer values, return their sum. If one value is the 
        same as another, it does not count towards the sum. 

        loneSum(1, 2, 3) → 6
        loneSum(3, 2, 3) → 2
        loneSum(3, 3, 3) → 0
        */
        public static int loneSum(params int[] values)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            foreach (int v in values) { 
                if (dict.ContainsKey(v))
                    dict[v]++;
                else
                    dict.Add(v, 1);
            }
            return dict.Where(x => x.Value == 1).Select(x => x.Key).Sum();
        }

        /*
        Given 3 int values, a b c, return their sum. 
        However, if one of the values is 13 then it does not count towards the sum 
        and values to its right do not count. So for example, if b is 13, then both 
        b and c do not count. 

        luckySum(1, 2, 3) → 6
        luckySum(1, 2, 13) → 3
        luckySum(1, 13, 3) → 1
        */
        public static int luckySum(params int[] values)
        {
            int sum = 0;
            foreach (int val in values)
            {
                if (val == 13)
                    break;
                else
                    sum += val;
            }
            return sum;
        }

        /*
        Given 3 int values, a b c, return their sum. 
        However, if one of the values is 13 then it does not count towards the sum 
        and values to its right do not count. So for example, if b is 13, then both 
        b and c do not count. Use Linq. Do not use loops.

        luckySumLinq(1, 2, 3) → 6
        luckySumLinq(1, 2, 13) → 3
        luckySumLinq(1, 13, 3) → 1
        */
        public static int luckySumLinq(params int[] values)
        {
            return values.TakeWhile(x => x != 13).Sum();
        }

        /*
        Given 3 int values, a b c, return their sum. 
        However, if any of the values is a teen -- in the 
        range 13..19 inclusive -- then that value counts as 0, 
        except 15 and 16 do not count as a teens. Write a 
        separate helper method "public int fixTeen(int n) {

        noTeenSum(1, 2, 3) → 6
        noTeenSum(2, 13, 1) → 3
        noTeenSum(2, 1, 14) → 3
        */
        public static int noTeenSum(params int[] values)
        {
            int sum = 0;
            foreach (int val in values)
            {
                sum += fixTeen(val);
            }
            return sum;
        }

        private static int fixTeen(int n)
        {
            if ((n >= 13 && n <= 14) || (n >= 17 && n <= 19))
                return 0;
            else
                return n;
        }

        /*
        Given 3 int values, a b c, return their sum. 
        However, if any of the values is a teen -- in the 
        range 13..19 inclusive -- then that value counts as 0, 
        except 15 and 16 do not count as a teens. 
        Write a separate helper "public int fixTeen(int n) {
        Use Linq. Do not use loops.
        noTeenSumLinq(1, 2, 3) → 6
        noTeenSumLinq(2, 13, 1) → 3
        noTeenSumLinq(2, 1, 14) → 3
        */
        public static int noTeenSumLinq(params int[] values)
        {
            return values.Select(x => fixTeen(x)).Sum();
        }

        /*
        For this problem, we'll round an int value up to the next multiple of 10 
        if its rightmost digit is 5 or more, so 15 rounds up to 20. Alternately, 
        round down to the previous multiple of 10 if its rightmost digit is less
        than 5, so 12 rounds down to 10. Given 3 ints, a b c, return the sum of 
        their rounded values. To avoid code repetition, write a separate helper 
        "public int round10(int num) {" and call it 3 times. 

        roundSum(16, 17, 18) → 60
        roundSum(12, 13, 14) → 30
        roundSum(6, 4, 4) → 10
        */
        public static int roundSum(params int[] values)
        {
            return values.Select(x => round10(x)).Sum();
        }

        public static int round10(int num)
        {
            if (num % 10 >= 5)
                return (num / 10) * 10 + 10;
            else
                return (num / 10) * 10;
        }

        /*
        Given three ints, a b c, return true if one of b or c is "close" 
        (differing from a by at most 1), while the other is "far", 
        differing from both other values by 2 or more. 

        closeFar(1, 2, 10) → true
        closeFar(1, 2, 3) → false
        closeFar(4, 1, 3) → true
        */
        public static bool closeFar(int a, params int[] values)
        {
            bool[] closeToA = new bool[values.Length];
            bool[] farFromOthers = new bool[values.Length];

            for (int i = 0; i < values.Length; i++)
            {
                closeToA[i] = Math.Abs(a - values[i]) <= 1;

                int min = Math.Abs(int.MaxValue);
                for (int j = 0; j < values.Length; j++)
                {
                    if (i != j)
                        min = Math.Min(min, Math.Abs(values[j] - values[i]));
                }
                farFromOthers[i] = min >= 2;
            }

            for (int i = 0; i < values.Length; i++)
            {
                if (closeToA[i])
                {
                    bool allFar = true;
                    for (int j = 0; j < values.Length; j++)
                    {
                        if (i != j)
                        {
                            if (!farFromOthers[j] || closeToA[j])
                            {
                                allFar = false;
                                break;
                            }
                        }
                    }
                    if (allFar)
                        return true;
                }
            }
            return false;
        }

        /*
        
        Given 2 int values greater than 0, return whichever value is 
        nearest to 21 without going over. Return 0 if they both go over. 

        blackjack(21, 19, 21, 21) → 21
        blackjack(21, 21, 19) → 21
        blackjack(21, 19, 22) → 19
        */
        public static int blackjack(int limit, params int[] values)
        {
            int max = 0;
            foreach (int val in values)
            {
                if (val <= limit)
                    if (val > max)
                        max = val;
            } 

            return max;
        }

        /*
        
        Given 2 int values greater than 0, return whichever value is 
        nearest to 21 without going over. Return 0 if they both go over. 
        Use Linq. Do not use loops.
        blackjackLinq(21, 19, 21, 21) → 21
        blackjackLinq(21, 21, 19) → 21
        blackjackLinq(21, 19, 22) → 19
        */
        public static int blackjackLinq(int limit, params int[] values)
        {
            return values.Where(x => x <= limit).DefaultIfEmpty(0).Max();
        }

        /*
        Given three ints, a b c, one of them is small, one is medium and one is large. 
        Return true if the three values are evenly spaced, so the difference between 
        small and medium is the same as the difference between medium and large. 

        evenlySpaced(2, 4, 6) → true
        evenlySpaced(4, 6, 2) → true
        evenlySpaced(4, 6, 3) → false
        */
        public static bool evenlySpaced(params int[] values)
        {
            Array.Sort(values);

            for (int i = 2; i < values.Length; i++)
                if (values[i] - values[i-1] != values[i - 1] - values[i - 2])
                    return false;

            return true;
        }

        /*
        We want make a package of goal kilos of chocolate. 
        We have small bars (1 kilo each) and big bars (5 kilos each). 
        Return the number of small bars to use, assuming we always 
        use big bars before small bars. Return -1 if it can't be done. 

        makeChocolate(4, 1, 9) → 4
        makeChocolate(4, 1, 10) → -1
        makeChocolate(4, 1, 7) → 2
        */
        public static int makeChocolate(int small, int big, int goal)
        {
            if (5 * big + small >= goal && goal % 5 <= small)
                return goal % 5;
            else
                return -1;
        }

    }
}
