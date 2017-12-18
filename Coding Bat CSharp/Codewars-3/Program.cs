using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars_3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("TwistedSum");
            Console.WriteLine(TwistedSum(10));// == 46 = 46 * 1 + 0);
            Console.WriteLine(TwistedSum(11));// == 48);
            Console.WriteLine(TwistedSum(12));// == 51);
            Console.WriteLine(TwistedSum(20));// == 102 = 46 * 2 + 10); 
            Console.WriteLine(TwistedSum(90));// == 774 = 46 * 9 + 360);
            Console.WriteLine(TwistedSum(99));// == 900 = );
            Console.WriteLine(TwistedSum(100));// == 901 = 46 * 10 + 441);

            Console.WriteLine("bouncingBall");
            Console.WriteLine(bouncingBall(h: 3, bounce: 0.66, window: 1.5) == 3);
            Console.WriteLine(bouncingBall(h: 3, bounce: 1, window: 1.5) == -1);
    
            Console.WriteLine("dirReduc");
            Console.WriteLine(dirReduc(new String[] { "NORTH", "SOUTH", "SOUTH", "EAST", "WEST", "NORTH", "WEST" }).SequenceEqual(new String[] { "WEST" }));
            Console.WriteLine(string.Join(" ", dirReduc(new String[] { "NORTH", "SOUTH", "SOUTH", "EAST", "WEST", "NORTH", "WEST" })));
            Console.WriteLine(dirReduc(new String[] { "NORTH", "SOUTH", "SOUTH", "EAST", "WEST", "NORTH" }).SequenceEqual(new String[] { }));
            Console.WriteLine(string.Join(" ", dirReduc(new String[] { "NORTH", "EAST", "SOUTH", "EAST", "WEST", "NORTH", "WEST" })));
        
            Console.WriteLine("isMerge");
            Console.WriteLine(isMerge("codewars", "cdw", "oears") == true);
            Console.WriteLine(isMerge("codewars", "cod", "wars") == false);
            Console.WriteLine(isMerge("Can we merge it? Yes, we can!", "n ee tYw n!", "Cawe mrgi? es, eca") == true);
            Console.WriteLine(isMerge("", "", "") == true);
            Console.WriteLine(isMerge("BananaBanana", "Banana", "Banana") == true);
        
            Console.WriteLine("orderWeight");
            Console.WriteLine(orderWeight("103 123 4444 99 2000") == "2000 103 123 4444 99");
            Console.WriteLine(orderWeight("2000 10003 1234000 44444444 9999 11 11 22 123") == "11 11 2000 10003 22 123 1234000 44444444 9999");
            
            Console.WriteLine("GetReadableTime");
            Console.WriteLine(GetReadableTime(0));// == "00:00:00");
            Console.WriteLine(GetReadableTime(60));// == "00:01:00");
            Console.WriteLine(GetReadableTime(86399));// == "23:59:59");
            Console.WriteLine(GetReadableTime(359999));// == "4.03:59:59"); 

            Console.WriteLine("Score");
            Console.WriteLine(Score(new int[] { 5, 1, 3, 4, 1 }) == 250);
            Console.WriteLine(Score(new int[] { 1, 1, 1, 3, 1 }) == 1100);
            Console.WriteLine(Score(new int[] { 2, 4, 4, 5, 4 }) == 450);
            
            Console.WriteLine("DigitalRoot");
            Console.WriteLine(DigitalRoot(15) ==  6);
            Console.WriteLine(DigitalRoot(16) == 7);
            
            Console.WriteLine("NextBiggerNumber3");
            Console.WriteLine(NextBiggerNumber3(9) == -1);
            Console.WriteLine(NextBiggerNumber3(12) == 21);
            Console.WriteLine(NextBiggerNumber3(102) == 120);
            Console.WriteLine(NextBiggerNumber3(144) == 414);
            Console.WriteLine(NextBiggerNumber3(513) == 531);
            Console.WriteLine(NextBiggerNumber3(2071) == 2107);
            Console.WriteLine(NextBiggerNumber3(8900) == 9008);

            Console.WriteLine("maxPizza");
            Console.WriteLine(maxPizza(-1) == -1);
            Console.WriteLine(maxPizza(0) == 1);
            Console.WriteLine(maxPizza(1) == 2);
            Console.WriteLine(maxPizza(2) == 4);
            Console.WriteLine(maxPizza(3) == 7);

            Console.WriteLine("isTriangleNumber");
            Console.WriteLine(isTriangleNumber(0) == true);
            Console.WriteLine(isTriangleNumber(1) == true);
            Console.WriteLine(isTriangleNumber(2) == false);
            Console.WriteLine(isTriangleNumber(3) == true);
            Console.WriteLine(isTriangleNumber(4) == false);
            Console.WriteLine(isTriangleNumber(5) == false);
            Console.WriteLine(isTriangleNumber(6) == true);
            Console.WriteLine(isTriangleNumber(10) == true);
            Console.WriteLine(isTriangleNumber(120) == true);
            Console.WriteLine(isTriangleNumber(300) == true);
            Console.WriteLine(isTriangleNumber(325) == true);
            
            Console.WriteLine("validBraces");
            Console.WriteLine(validBraces("(){}[]") == true);
            Console.WriteLine(validBraces("(}") == false);
            Console.WriteLine(validBraces("[(])") == false);
            Console.WriteLine(validBraces("([{}])") == true);
            
            Console.WriteLine("BinaryToString");
            Console.WriteLine(BinaryToString("") == "");
            Console.WriteLine(BinaryToString("0100100001100101011011000110110001101111") == "Hello");

            Console.WriteLine("sumStrings");
            Console.WriteLine(sumStrings("1", "2"));// == "3");
            Console.WriteLine(sumStrings("123", "456"));// == "579");
            Console.WriteLine(sumStrings("821429", "999999"));// == "1821428");
            Console.WriteLine(sumStrings("712577413488402631964821329", "100"));// == "712577413488402631964821429");

            Console.WriteLine("sumStrings2");
            Console.WriteLine(sumStrings2("1", "2"));// == "3");
            Console.WriteLine(sumStrings2("123", "456"));// == "579");
            Console.WriteLine(sumStrings2("821429", "999999"));// == "1821428");
            Console.WriteLine(sumStrings2("712577413488402631964821329", "100"));// == "712577413488402631964821429");

            Console.WriteLine("sumStrings3");
            Console.WriteLine(sumStrings3("1", "2"));// == "3");
            Console.WriteLine(sumStrings3("123", "456"));// == "579");
            Console.WriteLine(sumStrings3("821429", "999999"));// == "1821428");
            Console.WriteLine(sumStrings3("712577413488402631964821329", "100"));// == "712577413488402631964821429");

            Console.WriteLine("compoundArray");
            Console.WriteLine(compoundArray(new int[] { 1, 2, 3, 4, 5, 6 },
                new int[] { 9, 8, 7, 6 }).SequenceEqual(new int[] { 1, 9, 2, 8, 3, 7, 4, 6, 5, 6 }));

            Console.WriteLine("compoundArrayLinq");
            Console.WriteLine(compoundArrayLinq(new int[] { 1, 2, 3, 4, 5, 6 },
                new int[] { 9, 8, 7, 6 }).SequenceEqual(new int[] { 1, 9, 2, 8, 3, 7, 4, 6, 5, 6 }));
            
            Console.WriteLine("vowel2Index");
            Console.WriteLine(vowel2Index("this is my string") == "th3s 6s my str15ng");
            Console.WriteLine(vowel2Index("Codewars is the best site in the world")
                                       == "C2d4w6rs 10s th15 b18st s23t25 27n th32 w35rld");

            Console.WriteLine("vowel2IndexLinq");
            Console.WriteLine(vowel2IndexLinq("this is my string") == "th3s 6s my str15ng");
            Console.WriteLine(vowel2IndexLinq("Codewars is the best site in the world")
                                       == "C2d4w6rs 10s th15 b18st s23t25 27n th32 w35rld");

            
            Console.WriteLine("stat");
            Console.WriteLine(stat("01|15|59, 1|47|16, 01|17|20, 1|32|34, 2|17|17")
                           == "Range: 01|01|18 Average: 01|38|05 Median: 01|32|34");
            Console.WriteLine(stat("02|15|59, 2|47|16, 02|17|20, 2|32|34, 2|17|17, 2|22|00, 2|31|41")
                           == "Range: 00|31|17 Average: 02|26|18 Median: 02|22|00");
            Console.WriteLine(stat("01|15|59, 1|47|16, 01|17|20, 1|32|34"));
            
            Console.WriteLine("flipNumber");
            Console.WriteLine(flipNumber("012345") == "504132");
            
            Console.WriteLine("maxDiffLength");
            string[] MDL1 = { "hoqq", "bbllkw", "oox", "ejjuyyy", "plmiis", "xxxzgpsssa", "xxwwkktt", "znnnnfqknaz", "qqquuhii", "dvvvwz" };
            string[] MDL2 = { "cccooommaaqqoxii", "gggqaffhhh", "tttoowwwmmww" };
            Console.WriteLine(maxDiffLength(MDL1, MDL2) == 13);

            Console.WriteLine("inArray");
            string[] inA1 = { "arp", "live", "strong" };
            string[] inA2 = { "lively", "alive", "harp", "sharp", "armstrong" };
            string[] inAResult = { "arp", "live", "strong" };
            Console.WriteLine(inArray(inA1, inA2).SequenceEqual(inAResult));

            Console.WriteLine("inArrayLinq");
            string[] inAL1 = { "arp", "live", "strong" };
            string[] inAL2 = { "lively", "alive", "harp", "sharp", "armstrong" };
            string[] inALResult = { "arp", "live", "strong" };
            Console.WriteLine(inArrayLinq(inAL1, inAL2).SequenceEqual(inALResult));

            Console.WriteLine("inArrayLinq2");
            string[] inAL21 = { "arp", "live", "strong" };
            string[] inAL22 = { "lively", "alive", "harp", "sharp", "armstrong" };
            string[] inAL2Result = { "arp", "live", "strong" };
            Console.WriteLine(inArrayLinq2(inAL21, inAL22).SequenceEqual(inAL2Result));

            Console.WriteLine("seriesSum");
            Console.WriteLine(seriesSum(0) == "0.00");
            Console.WriteLine(seriesSum(1) ==  "1.00");
            Console.WriteLine(seriesSum(2) == "1.25"); // 1 + 1 / 4
            Console.WriteLine(seriesSum(5) == "1.57"); // 1 + 1 / 4 + 1 / 7 + 1 / 10 + 1 / 13

        }


        /*
        Find the sum of the digits of all the numbers from 1 to N (both ends included).
        For N = 10 the sum is 1+2+3+4+5+6+7+8+9+(1+0) = 46
        For N = 11 the sum is 1+2+3+4+5+6+7+8+9+(1+0)+(1+1) = 48
        For N = 12 the sum is 1+2+3+4+5+6+7+8+9+(1+0)+(1+1) +(1+2)= 51
        When N = 123 Then 1038
        When N = 1234 Then 15895
        When N = 12345 Then 214455
        */
        public static long TwistedSum(long n)
        {
            long sum = 0;
            for (long i = 1; i <= n; i++)
            {
                long val = i;
                while (val != 0)
                {
                    sum += val % 10;
                    val /= 10;
                }
            }
            return sum;
        }

        /*
         A child plays with a ball on the nth floor of a big building the height of which is known
        (float parameter "h" in meters, h > 0) .

        He lets out the ball. The ball rebounds for example to two-thirds of its height.
        (float parameter "bounce", 0 < bounce < 1)

        His mother looks out of a window that is 1.5 meters from the ground
        (float parameters window < h).

        How many times will the mother see the ball either falling or bouncing in front of the window
        (return a positive integer unless conditions are not fulfilled in which case return -1) ?

        Note
        You will admit that the ball can only be seen if the height of the rebouncing ball is stricty greater than the window parameter.

        Example:
        h = 3, bounce = 0.66, window = 1.5, result is 3
        h = 3, bounce = 1, window = 1.5, result is -1
        */
        public static int bouncingBall(double h, double bounce, double window)
        {
            // invalid input
            if (bounce >= 1 || window >= h || bounce <= 0 || h <= 0 || window <= 0)
                return -1;

            int count = 1;
            h = h * bounce;

            while (h > window)
            {
                count += 2;
                h = h * bounce;
            }

            if (h == window)
                count++;

            return count;
        }

        /*
        You have to write a function dirReduc which will take an array of strings and returns 
        an array of strings with the needless directions removed (W<->E or S<->N) side by side.
        Examples
        dirReduc(new String[]{"NORTH", "SOUTH", "SOUTH", "EAST", "WEST", "NORTH", "WEST"})
        => new String[]{"WEST"}
        dirReduc(new String[]{"NORTH", "SOUTH", "SOUTH", "EAST", "WEST", "NORTH"})
        => new String[]{}
        */

        public static string[] dirReduc(string[] arr)
        {
            List<string> directions = new List<string>(arr);
            bool didDelete = false;

            do
            {
                didDelete = reduceIt(directions);

            } while (didDelete);

            return directions.ToArray();
        }

        private static bool reduceIt(List<string> dir)
        {
            for (int i = dir.Count - 2; i >= 0; i--)
            {
                 if ((dir[i + 1] == "NORTH" && dir[i] == "SOUTH")
                  || (dir[i + 1] == "SOUTH" && dir[i] == "NORTH")
                  || (dir[i + 1] == "EAST"  && dir[i] == "WEST")
                  || (dir[i + 1] == "WEST"  && dir[i] == "EAST"))
                {
                    dir.RemoveAt(i + 1);
                    dir.RemoveAt(i);
                    return true;
                }
            }

            return false;
        }


        /*
        write an algorithm to check if a given string, s, can be formed from two other strings, part1 and part2.
        The restriction is that the characters in part1 and part2 are in the same order as in s.
        Example: 'codewars' is a merge from 'cdw' and 'oears':
            s:  c o d e w a r s   = codewars
            part1:  c   d   w         = cdw
            part2:    o   e   a r s   = oears

        Example2: Can we merge it? Yes, we can!' is a merge of 'n ee tYw n!' and 'Cawe mrgi? es, eca
  
        */
        public static bool isMerge(string s, string part1, string part2)
        {
            if (part1.Length + part2.Length != s.Length)
                return false;
            if (part1.Length == 0 && part2.Length == 0)
                return true;

            int posS = 0;
            int posP1 = 0;
            int posP2 = 0;
            Queue<char> q = new Queue<char>();
            bool matchP1 = false;
            bool matchP2 = false;
            bool didUseQ = false;

            while (posS < s.Length - 1 && (posP1 < part1.Length || posP2 < part2.Length))
            {
                matchP1 = posP1 < part1.Length && s[posS] == part1[posP1];
                matchP2 = posP2 < part2.Length && s[posS] == part2[posP2];

                if (matchP1 && matchP2)
                {
                    q.Enqueue(s[posS]);
                    didUseQ = true;
                    posS++;
                    posP1++;
                    posP2++;
                }

                else if (matchP1)
                {
                    posS++;
                    posP1++;
                }

                else if (matchP2)
                {
                    posS++;
                    posP2++;
                }

                else
                {
                    if (q.Count() != 0 && q.Peek() == s[posS])
                    {
                        q.Dequeue();
                        posS++;
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            while (q.Count() != 0 && q.Peek() == s[posS])
            {
                q.Dequeue();
                posS++;
            }

            if (posS == s.Length - 1 || (posS == s.Length && didUseQ))
                return true;
            else
                return false;
        }

        /*
        The weight of a number is the sum of its digits. For example 99 has a "weight" of 18. Given a 
        string with weights in normal order can you give this string ordered by "weights" of these numbers?  
        For Example:
        a = "56 65 74 100 99 68 86 180 90" ordered by numbers weights becomes: "100 180 90 56 65 74 68 86 99"
        When two numbers have the same "weight", let us class them as if they were strings and not numbers so 
        180 is before 90 since, having the same "weight" (9) it comes before as a string.
        All numbers in the list are positive numbers and the list can be empty.

        Console.WriteLine("orderWeight");    
        Console.WriteLine(orderWeight("2000 103 123 4444 99") == "103 123 4444 99 2000");
		Console.WriteLine(orderWeight("11 11 2000 10003 22 123 1234000 44444444 9999") == "2000 10003 1234000 44444444 9999 11 11 22 123");
        */

        public static string orderWeight(string strng)
        {
            var tlist = new List<Tuple<int, string>>();
            string[] delimiters = { " " };
            string[] input = strng.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            foreach (string s in input)
            {
                tlist.Add(new Tuple<int, string>(getWeight(s), s));
            }

            var result = tlist
              .OrderBy(x => x.Item1)
              .ThenBy(x => x.Item2)
              .Select(x => x.Item2)
              .ToList();

            return string.Join(" ", result);
        }

        private static int getWeight(string s)
        {
            string str = s.ToLower().Trim();
            int sum = 0;
            for (int i = 0; i < str.Length; i++)
            {
                sum += (int)char.GetNumericValue(str[i]);
            }
            return sum;
        }


        /*
        Write a function, which takes a non-negative integer (seconds) as input 
        and returns the time in a human-readable format (HH:MM:SS)

        HH = hours, padded to 2 digits, range: 00 - 99
        MM = minutes, padded to 2 digits, range: 00 - 59
        SS = seconds, padded to 2 digits, range: 00 - 59
        The maximum time never exceeds 359999 (99:59:59)

            Console.WriteLine("GetReadableTime");
            Console.WriteLine(GetReadableTime(0));// == "00:00:00");
            Console.WriteLine(GetReadableTime(60));// == "00:01:00");
            Console.WriteLine(GetReadableTime(86399));// == "23:59:59");
            Console.WriteLine(GetReadableTime(359999));// == "4.03:59:59");
        */
        public static string GetReadableTime(int seconds)
        {
            TimeSpan span = TimeSpan.FromSeconds(seconds);

            // Note to get this format: 99:59:59 use (int)span.TotalHours
            return (int)span.TotalHours + ":" + (int)span.Minutes + ":" + (int)span.Seconds;

            // Note to get this format: "4.03:59:59" use the default span.ToString()
            //return span.ToString();
        }


        /*
         Score a throw according to these rules. You will always be given an array with five six-sided dice values.

         Three 1's => 1000 points
         Three 6's =>  600 points
         Three 5's =>  500 points
         Three 4's =>  400 points
         Three 3's =>  300 points
         Three 2's =>  200 points
         One   1   =>  100 points
         One   5   =>   50 point
        
         A single die can only be counted once in each roll. For example, a "5" can only count as part of a triplet 
         (contributing to the 500 points) or as a single 50 points, but not both in the same roll.

         Example scoring
         Throw       Score
         5 1 3 4 1   50 + 2 * 100 = 250
         1 1 1 3 1   1000 + 100 = 1100
         2 4 4 5 4   400 + 50 = 450
         */

        public static int Score(int[] dice)
        {
            int[] vals = new int[6];

            foreach (int d in dice)
            {
                if (d == 1) vals[0]++;
                else if (d == 2) vals[1]++;
                else if (d == 3) vals[2]++;
                else if (d == 4) vals[3]++;
                else if (d == 5) vals[4]++;
                else if (d == 6) vals[5]++;
            }

            int score = 0;

            for (int i = 0; i < vals.Length; i++)
            {
                if (vals[i] >= 3)
                {
                    if (i == 0)
                        score += 1000;
                    else
                        score += 100 * (i + 1);
                    vals[i] -= 3;
                }
            }

            score += 100 * vals[0];
            score += 50 * vals[4];

            return score;
        }//score


        /*
        Compute sum of digits
        Ex: digital_root(16) => 7
        */
        public static int DigitalRoot(long n)
        {
            int sum = 0;

            while (n != 0)
            {
                sum += (int)(n % 10);
                n /= 10;
            }

            return sum;
        }

        /*
        Compute sum of digits
        Ex: digital_root("16") => 7
        */
        public static int DigitalRootString(string num)
        {
            int sum = 0;

            foreach (char c in num)
            {
                if (char.IsDigit(c))
                {
                    sum += (int)char.GetNumericValue(c);
                }
            }
            return sum;
        }

        /*
        You have to create a function that takes a positive integer number 
        and returns the next bigger number formed by the same digits:
        NextBiggerNumber3(12)==21
        NextBiggerNumber3(513)==531
        NextBiggerNumber3(2071)==2107
        NextBiggerNumber3(8900)==9008
        Assert.AreEqual(441, Kata.NextBiggerNumber3(414));
        Assert.AreEqual(414, Kata.NextBiggerNumber3(144));

        If no bigger number can be composed using those digits, return -1:
        NextBiggerNumber3(9)==-1
        NextBiggerNumber3(111)==-1
        NextBiggerNumber3(531)==-1
        */
        public static long NextBiggerNumber3(long n)
        {
            //Convert number to char array
            string s = n.ToString();

            //if input is too short return -1
            if (s == null || s.Length < 2)
                return -1;

            char[] arr = s.ToCharArray();
            int split = -1;
            string front = "";
            bool foundSplit = false;
            //loop over characters back to front
            for (int i = arr.Length - 2; i >= 0; i--)
            {
                //stop when you find a character smaller than the previous
                if (arr[i] < arr[i+1])
                {
                    //all characters before this become the 'front' substring
                    front = s.Substring(0, i);
                    split = i;
                    foundSplit = true;
                }
            }

            //if no split point found return -1
            if (!foundSplit)
                return -1;

            char smallest = 'z';
            int smallPos = -1;
            char stop = arr[split];

            //find the smallest character to the right larger than the stop character
            for (int i = split; i < arr.Length; i++)
            {
                if (arr[i] > stop && arr[i] < smallest)
                {
                    smallest = arr[i];
                    smallPos = i;
                }
            }

            //append that to front and remove it from the back
            front += smallest;
            arr[smallPos] = 'z';

            //sort the remaining back characters
            Array.Sort(arr, split, arr.Length - split);

            //create back string minus the final 'z'
            string back = new string(arr, split, arr.Length - split - 1);
            
            // append front and back
            string result = front + back;
            return Convert.ToInt64(result);
        }

        /*
        Cut a pizza into slices. Return the maximum number of slices (not necessarily of 
        equal size) possible with K cuts. If K is a negative number, the result must be -1. 
        Examples  maxPizza(0) == 1  maxPizza(1) == 2 maxPizza(2) == 4 maxPizza(3) == 7
        */
        public static int maxPizza(int cut)
        {
            if (cut < 0)
                return -1;

            int sum = 1;

            for(int i = cut; i > 0; i--)
                sum += i;

            return sum;
        }


        /*
        The nth triangle number is equal to the sum of the n natural numbers from 1 to n.
        Check if a given input is a valid triangle number. Return true if it is, false if it is not. 
        Note that any non-integers, including non-number types, are not triangle numbers.
        You may assume that the given input, if it is a number, is always positive.
        Triangle numbers: 0, 1, 3, 6, 10, 15, 21, ... 120 ...  300, 325, ...
        n = n*(n+1)/2
        */
        public static bool isTriangleNumber(long number)
        {
            long previous = 0;
            long current = 0;
            long increment = 1;

            while (current < number)
            {
                current = previous + increment;
                previous = current;
                increment++;
            }

            return current == number;
        }


        /*
        Write a function called validBraces that takes a string of braces, and determines if the order of the 
        braces is valid. validBraces should return true if the string is valid, and false if it's invalid.
        Examples: 
        validBraces( "(){}[]" ) => returns true 
        validBraces( "(}" ) => returns false 
        validBraces( "[(])" ) => returns false 
        validBraces( "([{}])" ) => returns true 
        */
        public static bool validBraces(String input)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in input)
            {
                if (c == '(' || c == '[' || c == '{')
                {
                     stack.Push(c);
                }
                else if (c == ')' || c == ']' || c == '}')
                {
                    if (stack.Count == 0)
                        return false;

                    char closing = stack.Pop();

                    if (c == ')' && closing != '(')
                            return false;
                    else if (c == ']' && closing != '[')
                            return false;
                    else if (c == '}' && closing != '{')
                            return false;

                }
            }

            if (stack.Count == 0)
                return true;
            else
                return false;
        }

        /*
        Write a function that takes in a binary string and returns the equivalent decoded text (the text is ASCII encoded).
        Each 8 bits on the binary string represent 1 character on the ASCII table.
        The input string will always be a valid binary string.
        In the case of an empty binary string your function should return an empty string.
        Console.WriteLine(BinaryToString("") == "");
        Console.WriteLine(BinaryToString("0100100001100101011011000110110001101111") == "Hello");
        */

        public static string BinaryToString(string binary)
        {
            var text = new StringBuilder();
            byte[] bytes = new byte[binary.Length / 8];

            for (int i = 0; i < binary.Length; i += 8)
            {
                bytes[i / 8] = Convert.ToByte(binary.Substring(i, 8), 2);
            }

            return Encoding.ASCII.GetString(bytes);
        }

        /*
        Given the string representations of two integers, return the string representation of their sum.
        For example:
        Console.WriteLine("sumStrings"");
        Console.WriteLine(sumStrings("1","2") == "3");
        Console.WriteLine(sumStrings("123","456") == "579");
        Console.WriteLine(sumStrings("821429", "999999"));// == "1821428");
        The input will contain no characters besides the ten numerals "0" to "9".
        NOTE The tests will try to overflow your INTS!
        test7 == "712577413488402631964821329"
        test8 == "131151201344081895336534324866"
        */
        public static string sumStrings(string a, string b)
        {
            List<string> aParts = new List<string>();
            List<string> bParts = new List<string>();
            const int chunk = 6;

            if (a.Length <= chunk)
                aParts.Add(a);
            else
            {
                for (int i = a.Length - chunk; i >= 0; i -= chunk)
                {
                    aParts.Add(a.Substring(i, chunk));
                    if (i != 0 && i < chunk)
                        aParts.Add(a.Substring(0,i));
                }
            }

            if (b.Length <= chunk)
                bParts.Add(b);
            else
            {
                for (int i = b.Length - chunk; i >= 0; i -= chunk)
                {
                    bParts.Add(b.Substring(i, chunk));
                    if (i != 0 && i < chunk)
                        bParts.Add(b.Substring(0, i));
                }
            }

            List<long> results = new List<long>();
            long overage = 0;
            long sum = 0;
            for(int i = 0; i < Math.Max(aParts.Count, bParts.Count); i++)
            {
                if (i < aParts.Count && i < bParts.Count)
                    sum = overage + Convert.ToInt64(aParts[i]) + Convert.ToInt64(bParts[i]);
                else if (i < aParts.Count)
                    sum = overage + Convert.ToInt64(aParts[i]);
                else
                    sum = overage + Convert.ToInt64(bParts[i]);

                overage = 0;
                string sumString = sum.ToString();
                if (sumString.Length > chunk)
                {
                    int len = sumString.Length - chunk;
                    string front = sumString.Substring(0, len);
                    string back = sumString.Substring(len);
                    overage = Convert.ToInt64(front);
                    sum = Convert.ToInt64(back);
                }
                results.Add(sum);
            }

            StringBuilder sb = new StringBuilder();

            for(int i = results.Count - 1; i >= 0; i--)
            {
                sb.Append(results[i]);
            }

            if (overage > 0)
                sb.Insert(0, overage);

            return sb.ToString();
        }

        /*
        Given the string representations of two integers, return the string representation of their sum.
        For example:
        Console.WriteLine("sumStrings"");
        Console.WriteLine(sumStrings("1","2") == "3");
        Console.WriteLine(sumStrings("123","456") == "579");
        Console.WriteLine(sumStrings("821429", "999999"));// == "1821428");
        The input will contain no characters besides the ten numerals "0" to "9".
        NOTE The tests will try to overflow your INTS!
        test7 == "712577413488402631964821329"
        test8 == "131151201344081895336534324866"
        */
        public static string sumStrings2(string a, string b)
        {
            string longest = a.Length >= b.Length ? a : b;
            string shortest = a.Length < b.Length ? a : b;
            int carry = 0;
            int sum = 0;
            int pos = longest.Length - 1;
            int differenceInLengths = longest.Length - shortest.Length;
            StringBuilder result = new StringBuilder();

            do
            {
                sum = carry + (int)Char.GetNumericValue(longest[pos]);

                if (pos - differenceInLengths >= 0)
                    sum += (int)Char.GetNumericValue(shortest[pos - differenceInLengths]);

                if (sum >= 10)
                {
                    carry = sum / 10;
                    sum = sum % 10;
                }
                else
                    carry = 0;

                result.Insert(0, sum);

            } while (--pos >= 0);

            if (carry > 0)
                result.Insert(0, carry);

            return result.ToString();
        }

        /*
        Given the string representations of two integers, return the string representation of their sum.
        For example:
        Console.WriteLine("sumStrings"");
        Console.WriteLine(sumStrings("1","2") == "3");
        Console.WriteLine(sumStrings("123","456") == "579");
        Console.WriteLine(sumStrings("821429", "999999"));// == "1821428");
        The input will contain no characters besides the ten numerals "0" to "9".
        NOTE The tests will try to overflow your INTS!
        test7 == "712577413488402631964821329"
        test8 == "131151201344081895336534324866"
        */
        public static string sumStrings3(string a, string b)
        {
            StringBuilder sb = new StringBuilder();
            int posA = a.Length - 1;
            int posB = b.Length - 1;
            int carry = 0;
            int sum = 0;

            while (posA > -1 || posB > -1)
            { 
                if (posA > -1 && posB > -1)
                    sum = (int)(char.GetNumericValue(a[posA]) + char.GetNumericValue(b[posB]));
                else if (posA > -1)
                    sum = (int)(char.GetNumericValue(a[posA]));
                else if (posB > -1)
                    sum = (int)(char.GetNumericValue(b[posB]));

                sb.Insert(0, carry + sum % 10);
                carry = sum >= 10 ? 1 : 0;
                posA--;
                posB--;
            }

            if (carry > 0)
                sb.Insert(0, carry);

            return sb.ToString();
        }

        /*
        You have to create a method "compoundArray" which should take as input two int arrays of 
        different length and return one int array with numbers of both arrays shuffled one by one. 
        Example: Input - {1,2,3,4,5,6} and {9,8,7,6} Output - {1,9,2,8,3,7,4,6,5,6}
        */
        public static int[] compoundArray(int[] a, int[] b)
        {
            int aLen = a.Length;
            int bLen = b.Length;
            int min = Math.Min(aLen, bLen);
            int[] result = new int[aLen + bLen];

            for (int i = 0; i < min; i++)
            {
                int rpos = 2 * i;
                result[rpos] = a[i];
                result[rpos + 1] = b[i];
            }

            if (aLen < bLen)
                Array.Copy(b, aLen, result, aLen * 2, bLen - aLen);
            else if (bLen < aLen)
                Array.Copy(a, bLen, result, bLen * 2, aLen - bLen);

            return result;
        }

        /*
        You have to create a method "compoundArray" which should take as input two int arrays of 
        different length and return one int array with numbers of both arrays shuffled one by one. 
        Example: Input - {1,2,3,4,5,6} and {9,8,7,6} Output - {1,9,2,8,3,7,4,6,5,6}
        Use Linq. Do not use loops.
        */
        public static int[] compoundArrayLinq(int[] a, int[] b)
        {
            List<int> result =  a.Zip(b, (x, y) => new[] { x, y })
                             .SelectMany(element => element).ToList();

            int[] longer = a.Length >= b.Length ? a : b;
            int[] shorter = a.Length >= b.Length ? b : a;
            int lenC = longer.Length - shorter.Length;
            int[] c = new int[lenC];

            Array.Copy(longer, shorter.Length, c, 0, lenC);
            result.AddRange(c);

            return result.ToArray();
        }

        /*
        Vowel2Index(string s)
        Takes in a string and replaces all the vowels [a,e,i,o,u] 
        with their respective positions within that string. 
        Kata.vowel2Index("this is my string") == "th3s 6s my str15ng"
        Kata.vowel2Index("Codewars is the best site in the world")
        */
        public static string vowel2Index(string str)
        {
            StringBuilder sb = new StringBuilder();
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            for (int i = 0; i < str.Length; i++)
            {
                if (vowels.Contains(str[i]))
                    sb.Append(i + 1);
                else
                    sb.Append(str[i]);
            }

            return sb.ToString();
        }

        /*
        Vowel2IndexLinq(string s)
        Takes in a string and replaces all the vowels [a,e,i,o,u] 
        with their respective positions within that string. 
        vowel2IndexLinq("this is my string") == "th3s 6s my str15ng"
        vowel2IndexLinq("Codewars is the best site in the world")
        Use Linq. Do not use loops.
        */
        public static string vowel2IndexLinq(string str)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            return string.Concat(str.SelectMany((c, i) => vowels.Contains(c) ? (i + 1).ToString() : c.ToString()));
        }

        /*
        Each part of the string is of the form: h|m|s where h, m, s are positive 
        or null integer (represented as strings) with one or two digits. 
        You are asked for giving three statistics; range, average and median 
        where hh, mm, ss are integers (represented by strings) with each 2 digits.
        Example Input: "01|15|59, 1|47|6, 01|17|20, 1|32|34, 2|3|17"
        Example Output: "Range: 00|47|18 Average: 01|35|15 Median: 01|32|34"
        */
        public static string stat(string strg)
        {
            // In:  "01|15|59, 1|47|16, 01|17|20, 1|32|34, 2|17|17"
            // Out: "Range: 01|01|18 Average: 01|38|05 Median: 01|32|34"
            List<TimeSpan> times = new List<TimeSpan>();
            string[] timeStrings = strg.Split(',');

            foreach (string tStr in timeStrings)
            {
                TimeSpan span = TimeSpan.Parse(tStr.Trim().Replace("|", ":"));
                times.Add(span);
            }

            times.Sort();

            TimeSpan min = times.Min();
            TimeSpan max = times.Max();
            TimeSpan range = max - min;
            TimeSpan sum = default(TimeSpan);

            foreach (TimeSpan ts in times)
            {
                sum += ts;
            }

            
            TimeSpan average = TimeSpan.FromSeconds(Math.Round(sum.TotalSeconds / times.Count()));
            TimeSpan median = times[0];

            if (times.Count() % 2 == 1)
                median = times[times.Count() / 2];
            else
            {
                TimeSpan doubleMedian = times[times.Count() / 2 - 1] + times[times.Count() / 2];
                median = TimeSpan.FromSeconds(Math.Round(doubleMedian.TotalSeconds / 2));
            }

            string rangeStr = range.ToString().Replace(":", "|");
            string averageStr = average.ToString().Replace(":", "|");
            string medianStr = median.ToString().Replace(":", "|");
            string result = "Range: " + rangeStr + " Average: " + averageStr + " Median: " + medianStr;

            return result;
        }


        /*
        You are going to be given a string. Let's say you start with this: 012345
        The first thing you do is reverse it:543210
        Then you will take the string from the 1st position and reverse it again:501234
        Then you will take the string from the 2nd position and reverse it again:504321
        Then you will take the string from the 3rd position and reverse it again:504123
        Continue this pattern until you have done every single position, and then you will 
        return the string you have created. For this particular number, you would return: 504132
        */
        public static string flipNumber(string n)
        {
            string str = n;

            for (int i = 0; i < n.Length - 1; i++)
            {
                str = flipString(str, i);
            }

            return str;
        }

        private static string flipString(string n, int index)
        {
            string left = n.Substring(0, index);
            char[] right = n.Substring(index).ToCharArray();
            Array.Reverse(right);
            return  left + new string(right);
        }

        /*
        You are given two arrays a1 and a2 of strings.Each string is composed with letters from a to z.
        Let x be any string in the first array and y be any string in the second array.
        Find max(abs(length(x) − length(y))).  If a1 or a2 are empty return -1.
        s1 = ["hoqq", "bbllkw", "oox", "ejjuyyy", "plmiis", "xxxzgpsssa", "xxwwkktt", "znnnnfqknaz", "qqquuhii", "dvvvwz"]
        s2 = ["cccooommaaqqoxii", "gggqaffhhh", "tttoowwwmmww"]
        maxDiffLength(s1, s2) --> 13
        */
        public static int maxDiffLength(string[] a1, string[] a2)
        {
            if (a1 == null || a1.Length == 0 || a2 == null || a2.Length == 0)
                return -1;

            int max1 = a1.Max(w => w.Length);
            int max2 = a2.Max(w => w.Length);
            int min1 = a1.Min(w => w.Length);
            int min2 = a2.Min(w => w.Length);

            return Math.Max(max1 - min2, max2 - min1);
        }

        /*
        Given two arrays of strings a1 and a2 return a sorted array r in lexicographical order 
        and without duplicates of the strings of a1 which are substrings of strings of a2.
        Example 1:
            a1 = ["arp", "live", "strong"]
            a2 = ["lively", "alive", "harp", "sharp", "armstrong"]
            returns ["arp", "live", "strong"]
        Example 2:
            a1 = ["tarp", "mice", "bull"]
            a2 = ["lively", "alive", "harp", "sharp", "armstrong"]
            returns []
        */
        public static string[] inArray(string[] array1, string[] array2)
        {
            List<string> list = new List<string>();

            foreach(string s in array2)
                foreach(string t in array1)
                    if (!list.Contains(t) && s.Contains(t))
                    {
                        list.Add(t);
                        break;
                    }
                        
            list.Sort();
            //list.ForEach(item => Console.Write(item + " "));
            return list.ToArray();
        }

        /*
        Given two arrays of strings a1 and a2 return a sorted array r in lexicographical order 
        and without duplicates of the strings of a1 which are substrings of strings of a2.
        Example 1:
            a1 = ["arp", "live", "strong"]
            a2 = ["lively", "alive", "harp", "sharp", "armstrong"]
            returns ["arp", "live", "strong"]
        Example 2:
            a1 = ["tarp", "mice", "bull"]
            a2 = ["lively", "alive", "harp", "sharp", "armstrong"]
            returns []
        */
        public static string[] inArrayLinq(string[] array1, string[] array2)
        {
            string joined2 = string.Join(",", array2);
            string[] result = array1.Distinct().Where(element => joined2.Contains(element)).ToArray();
            Array.Sort(result);
            return result;
        }

        /*
        Given two arrays of strings a1 and a2 return a sorted array r in lexicographical order 
        and without duplicates of the strings of a1 which are substrings of strings of a2.
        Example 1:
            a1 = ["arp", "live", "strong"]
            a2 = ["lively", "alive", "harp", "sharp", "armstrong"]
            returns ["arp", "live", "strong"]
        Example 2:
            a1 = ["tarp", "mice", "bull"]
            a2 = ["lively", "alive", "harp", "sharp", "armstrong"]
            returns []
        */
        public static string[] inArrayLinq2(string[] array1, string[] array2)
        {
            return array1.Distinct()
                         .Where(s1 => array2.Any(s2 => s2.Contains(s1)))
                         .OrderBy(s => s)
                         .ToArray();
        }

        /*
        Return the sum of following series upto nth term(parameter).
        Series: 1 + 1/4 + 1/7 + 1/10 + 1/13 + 1/16 +...
        Rules:
        You need to round the answer upto 2 decimal places and return it as String.
        If the given value is 0 then it should return 0.00
        You will only be given Natural Numbers as arguments.
        Examples:
        SeriesSum(1) => 1 = "1.00"
        SeriesSum(2) => 1 + 1/4 = "1.25"
        SeriesSum(5) => 1 + 1/4 + 1/7 + 1/10 + 1/13 = "1.57"
        */
        public static string seriesSum(int n)
        {
            double numerator = 1.0;
            int denominator = 1;
            double sum = 0;

            for (int i = 0; i < n; i++)
            {
                sum += (numerator / denominator);
                denominator += 3;
            }

            return Math.Round(sum, 2).ToString("0.00");
        }

    }
}
