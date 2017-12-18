using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("countEvens");
            Console.WriteLine(countEvens(new int[] { 2, 1, 2, 3, 4}) == 3);
            Console.WriteLine(countEvens(new int[] { 2, 2, 0}) == 3);
            Console.WriteLine(countEvens(new int[] { 1, 3, 5}) == 0);

            Console.WriteLine("countEvensLinq");
            Console.WriteLine(countEvensLinq(new int[] { 2, 1, 2, 3, 4 }) == 3);
            Console.WriteLine(countEvensLinq(new int[] { 2, 2, 0 }) == 3);
            Console.WriteLine(countEvensLinq(new int[] { 1, 3, 5 }) == 0);

            Console.WriteLine("bigDiff");
            Console.WriteLine(bigDiff(new int[] { 10, 3, 5, 6 }) == 7);
            Console.WriteLine(bigDiff(new int[] { 7, 2, 10, 9 }) == 8);
            Console.WriteLine(bigDiff(new int[] { 2, 10, 7, 2 }) == 8);

            Console.WriteLine("bigDiffLinq");
            Console.WriteLine(bigDiffLinq(new int[] { 10, 3, 5, 6 }) == 7);
            Console.WriteLine(bigDiffLinq(new int[] { 7, 2, 10, 9 }) == 8);
            Console.WriteLine(bigDiffLinq(new int[] { 2, 10, 7, 2 }) == 8);

            Console.WriteLine("centeredAverage");
            Console.WriteLine(centeredAverage(new int[] { 1, 2, 3, 4, 100 }) == 3);
            Console.WriteLine(centeredAverage(new int[] { 1, 1, 5, 5, 10, 8, 7 }) == 5);
            Console.WriteLine(centeredAverage(new int[] { -10, -4, -2, -4, -2, 0}) == -3);

            Console.WriteLine("centeredAverageLinq");
            Console.WriteLine(centeredAverageLinq(new int[] { 1, 2, 3, 4, 100 }) == 3);
            Console.WriteLine(centeredAverageLinq(new int[] { 1, 1, 5, 5, 10, 8, 7 }) == 5);
            Console.WriteLine(centeredAverageLinq(new int[] { -10, -4, -2, -4, -2, 0 }) == -3);

            Console.WriteLine("sum13");
            Console.WriteLine(sum13(new int[] { 1, 13, 2, 2, 2, 1 }, 13, true) == 6);
            Console.WriteLine(sum13(new int[] { 13, 13, 2, 1, 1}, 13, true) == 2);
            Console.WriteLine(sum13(new int[] { 1, 2, 2, 1, 13}, 13, true) == 6);

            Console.WriteLine("sum13Linq");
            Console.WriteLine(sum13Linq(new int[] { 1, 13, 2, 2, 2, 1 }, 13, true) == 6);
            Console.WriteLine(sum13Linq(new int[] { 13, 13, 2, 1, 1 }, 13, true) == 2);
            Console.WriteLine(sum13Linq(new int[] { 1, 2, 2, 1, 13 }, 13, true) == 6);

            Console.WriteLine("sum67");
            Console.WriteLine(sum67(new int[] { 1, 2, 2}, 6, 7) == 5);
            Console.WriteLine(sum67(new int[] { 1, 2, 2, 6, 99, 99, 7}, 6, 7) == 5);
            Console.WriteLine(sum67(new int[] { 1, 1, 6, 7, 2}, 6, 7) == 4);
            
            Console.WriteLine("has22");
            Console.WriteLine(has22(new int[] { 1, 2, 2}, 2, 2) == true);
            Console.WriteLine(has22(new int[] { 1, 2, 1, 2}, 2, 2) == false);
            Console.WriteLine(has22(new int[] { 2, 1, 2}, 2, 2) == false);

            Console.WriteLine("has22Linq");
            Console.WriteLine(has22Linq(new int[] { 1, 2, 2 }, 2, 2) == true);
            Console.WriteLine(has22Linq(new int[] { 1, 2, 1, 2 }, 2, 2) == false);
            Console.WriteLine(has22Linq(new int[] { 2, 1, 2 }, 2, 2) == false);

            Console.WriteLine("lucky13");
            Console.WriteLine(lucky13(new int[] { 0, 2, 4}, 1, 3) == true);
            Console.WriteLine(lucky13(new int[] { 1, 2, 3}, 1, 3) == false);
            Console.WriteLine(lucky13(new int[] { 1, 2, 4}, 1, 3) == false);
            
            Console.WriteLine("sum28");
            Console.WriteLine(sum28(new int[] { 2, 3, 2, 2, 4, 2}, 2, 8) == true);
            Console.WriteLine(sum28(new int[] { 2, 3, 2, 2, 4, 2, 2}, 2, 8) == false);
            Console.WriteLine(sum28(new int[] { 1, 2, 3, 4}, 2, 8) == false);

            Console.WriteLine("sum28Linq");
            Console.WriteLine(sum28Linq(new int[] { 2, 3, 2, 2, 4, 2 }, 2, 8) == true);
            Console.WriteLine(sum28Linq(new int[] { 2, 3, 2, 2, 4, 2, 2 }, 2, 8) == false);
            Console.WriteLine(sum28Linq(new int[] { 1, 2, 3, 4 }, 2, 8) == false);

            Console.WriteLine("more14");
            Console.WriteLine(more14(new int[] { 1, 4, 1}, 1, 4) == true);
            Console.WriteLine(more14(new int[] { 1, 4, 1, 4}, 1, 4) == false);
            Console.WriteLine(more14(new int[] { 1, 1}, 1, 4) == true);

            Console.WriteLine("more14Linq");
            Console.WriteLine(more14Linq(new int[] { 1, 4, 1 }, 1, 4) == true);
            Console.WriteLine(more14Linq(new int[] { 1, 4, 1, 4 }, 1, 4) == false);
            Console.WriteLine(more14Linq(new int[] { 1, 1 }, 1, 4) == true);

            Console.WriteLine("fizzArray");
            Console.WriteLine(fizzArray(4).SequenceEqual(new int[] { 0, 1, 2, 3 }));
            Console.WriteLine(fizzArray(1).SequenceEqual(new int[] { 0 }));
            Console.WriteLine(fizzArray(10).SequenceEqual(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9}));

            Console.WriteLine("fizzArrayLinq");
            Console.WriteLine(fizzArrayLinq(4).SequenceEqual(new int[] { 0, 1, 2, 3 }));
            Console.WriteLine(fizzArrayLinq(1).SequenceEqual(new int[] { 0 }));
            Console.WriteLine(fizzArrayLinq(10).SequenceEqual(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }));

            Console.WriteLine("only14");
            Console.WriteLine(only14(new int[] { 1, 4, 1, 4}) == true);
            Console.WriteLine(only14(new int[] { 1, 4, 2, 4}) == false);
            Console.WriteLine(only14(new int[] { 1, 1}) == true);

            Console.WriteLine("only14Linq");
            Console.WriteLine(only14Linq(new int[] { 1, 4, 1, 4 }) == true);
            Console.WriteLine(only14Linq(new int[] { 1, 4, 2, 4 }) == false);
            Console.WriteLine(only14Linq(new int[] { 1, 1 }) == true);

            Console.WriteLine("fizzArray2");
            Console.WriteLine(fizzArray2(4).SequenceEqual(new string[] { "0", "1", "2", "3"}));
            Console.WriteLine(fizzArray2(10).SequenceEqual(new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9"}));
            Console.WriteLine(fizzArray2(2).SequenceEqual(new string[] { "0", "1"}));

            Console.WriteLine("fizzArray2Linq");
            Console.WriteLine(fizzArray2Linq(4).SequenceEqual(new string[] { "0", "1", "2", "3" }));
            Console.WriteLine(fizzArray2Linq(10).SequenceEqual(new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" }));
            Console.WriteLine(fizzArray2Linq(2).SequenceEqual(new string[] { "0", "1" }));

            Console.WriteLine("no14");
            Console.WriteLine(no14(new int[] { 1, 2, 3 }, 1, 4) == true);
            Console.WriteLine(no14(new int[] { 1, 2, 3, 4}, 1, 4) == false);
            Console.WriteLine(no14(new int[] { 2, 3, 4}, 1, 4) == true);

            Console.WriteLine("no14Linq");
            Console.WriteLine(no14Linq(new int[] { 1, 2, 3 }, 1, 4) == true);
            Console.WriteLine(no14Linq(new int[] { 1, 2, 3, 4 }, 1, 4) == false);
            Console.WriteLine(no14Linq(new int[] { 2, 3, 4 }, 1, 4) == true);

            Console.WriteLine("isEverywhere");
            Console.WriteLine(isEverywhere(new int[] { 1, 2, 1, 3}, 1) == true);
            Console.WriteLine(isEverywhere(new int[] { 1, 2, 1, 3}, 2) == false);
            Console.WriteLine(isEverywhere(new int[] { 1, 2, 1, 3, 4}, 1) == false);

            Console.WriteLine("isEverywhereLinq");
            Console.WriteLine(isEverywhereLinq(new int[] { 1, 2, 1, 3 }, 1) == true);
            Console.WriteLine(isEverywhereLinq(new int[] { 1, 2, 1, 3 }, 2) == false);
            Console.WriteLine(isEverywhereLinq(new int[] { 1, 2, 1, 3, 4 }, 1) == false);

            Console.WriteLine("either24");
            Console.WriteLine(either24(new int[] { 1, 2, 2}, 2, 4) == true);
            Console.WriteLine(either24(new int[] { 4, 4, 1}, 2, 4) == true);
            Console.WriteLine(either24(new int[] { 4, 4, 1, 2, 2}, 2, 4) == false);

            Console.WriteLine("matchUp");
            Console.WriteLine(matchUp(new int[] { 1, 2, 3 }, new int[] { 2, 3, 10 }) == 2);
            Console.WriteLine(matchUp(new int[] { 1, 2, 3}, new int[] { 2, 3, 5}) == 3);
            Console.WriteLine(matchUp(new int[] { 1, 2, 3}, new int[] { 2, 3, 3}) == 2);

            Console.WriteLine("matchUpLinq");
            Console.WriteLine(matchUpLinq(new int[] { 1, 2, 3 }, new int[] { 2, 3, 10 }) == 2);
            Console.WriteLine(matchUpLinq(new int[] { 1, 2, 3 }, new int[] { 2, 3, 5 }) == 3);
            Console.WriteLine(matchUpLinq(new int[] { 1, 2, 3 }, new int[] { 2, 3, 3 }) == 2);

            Console.WriteLine("has77");
            Console.WriteLine(has77(new int[] { 1, 7, 7 }) == true);
            Console.WriteLine(has77(new int[] { 1, 7, 1, 7 }) == true);
            Console.WriteLine(has77(new int[] { 1, 7, 1, 1, 7 }) == false);

            Console.WriteLine("has77Linq");
            Console.WriteLine(has77Linq(new int[] { 1, 7, 7 }) == true);
            Console.WriteLine(has77Linq(new int[] { 1, 7, 1, 7 }) == true);
            Console.WriteLine(has77Linq(new int[] { 1, 7, 1, 1, 7 }) == false);

            Console.WriteLine("modThree");
            Console.WriteLine(modThree(new int[] { 2, 1, 3, 5}) == true);
            Console.WriteLine(modThree(new int[] { 2, 1, 2, 5}) == false);
            Console.WriteLine(modThree(new int[] { 2, 4, 2, 5}) == true);
            Console.WriteLine(modThree(new int[] { 1 }) == false);
            Console.WriteLine(modThree(new int[] { }) == false);

            Console.WriteLine("modThreeLinq");
            Console.WriteLine(modThreeLinq(new int[] { 2, 1, 3, 5 }) == true);
            Console.WriteLine(modThreeLinq(new int[] { 2, 1, 2, 5 }) == false);
            Console.WriteLine(modThreeLinq(new int[] { 2, 4, 2, 5 }) == true);
            Console.WriteLine(modThreeLinq(new int[] { 1 }) == false);
            Console.WriteLine(modThreeLinq(new int[] { }) == false);

            Console.WriteLine("haveThree");
            Console.WriteLine(haveThree(new int[] { 3, 1, 3, 1, 3 }) == true);
            Console.WriteLine(haveThree(new int[] { 3, 1, 3, 3}) == false);
            Console.WriteLine(haveThree(new int[] { 3, 4, 3, 3, 4}) == false);

            Console.WriteLine("haveThreeLinq");
            Console.WriteLine(haveThreeLinq(new int[] { 3, 1, 3, 1, 3 }) == true);
            Console.WriteLine(haveThreeLinq(new int[] { 3, 1, 3, 3 }) == false);
            Console.WriteLine(haveThreeLinq(new int[] { 3, 4, 3, 3, 4 }) == false);

            Console.WriteLine("has12");
            Console.WriteLine(has12(new int[] { 1, 2, 1}, 1, 2) == true);
            Console.WriteLine(has12(new int[] { 3, 1, 2}, 1, 2) == true);
            Console.WriteLine(has12(new int[] { 3, 2, 1}, 1, 2) == false);

            Console.WriteLine("twoTwo");
            Console.WriteLine(twoTwo(new int[] { 4, 2, 2}) == true);
            Console.WriteLine(twoTwo(new int[] { 2, 2, 4}) == true);
            Console.WriteLine(twoTwo(new int[] { 2, 4, 2}) == false);

            Console.WriteLine("twoTwoLinq");
            Console.WriteLine(twoTwoLinq(new int[] { 4, 2, 2 }) == true);
            Console.WriteLine(twoTwoLinq(new int[] { 2, 2, 4 }) == true);
            Console.WriteLine(twoTwoLinq(new int[] { 2, 4, 2 }) == false);

            Console.WriteLine("sameEnds");
            Console.WriteLine(sameEnds(new int[] { 5, 6, 45, 99, 13, 5, 6}, 1) == false);
            Console.WriteLine(sameEnds(new int[] { 5, 6, 45, 99, 13, 5, 6}, 2) == true);
            Console.WriteLine(sameEnds(new int[] { 5, 6, 45, 99, 13, 5, 6}, 3) == false);

            Console.WriteLine("sameEndsLinq");
            Console.WriteLine(sameEndsLinq(new int[] { 5, 6, 45, 99, 13, 5, 6 }, 1) == false);
            Console.WriteLine(sameEndsLinq(new int[] { 5, 6, 45, 99, 13, 5, 6 }, 2) == true);
            Console.WriteLine(sameEndsLinq(new int[] { 5, 6, 45, 99, 13, 5, 6 }, 3) == false);
            
            Console.WriteLine("tripleUp");
            Console.WriteLine(tripleUp(new int[] { 1, 4, 5, 6, 2}) == true);
            Console.WriteLine(tripleUp(new int[] { 1, 2, 3})  == true);
            Console.WriteLine(tripleUp(new int[] { 1, 2, 4})  == false);

            Console.WriteLine("tripleUpLinq");
            Console.WriteLine(tripleUpLinq(new int[] { 1, 4, 5, 6, 2}) == true);
            Console.WriteLine(tripleUpLinq(new int[] { 1, 2, 3})  == true);
            Console.WriteLine(tripleUpLinq(new int[] { 1, 2, 4})  == false);

            Console.WriteLine("fizzArray3");
            Console.WriteLine(fizzArray3(5, 10).SequenceEqual(new int[] { 5, 6, 7, 8, 9 }));
            Console.WriteLine(fizzArray3(11, 18).SequenceEqual(new int[] { 11, 12, 13, 14, 15, 16, 17}));
            Console.WriteLine(fizzArray3(1, 3).SequenceEqual(new int[] { 1, 2}));

            Console.WriteLine("fizzArray3Linq");
            Console.WriteLine(fizzArray3Linq(5, 10).SequenceEqual(new int[] { 5, 6, 7, 8, 9 }));
            Console.WriteLine(fizzArray3Linq(11, 18).SequenceEqual(new int[] { 11, 12, 13, 14, 15, 16, 17 }));
            Console.WriteLine(fizzArray3Linq(1, 3).SequenceEqual(new int[] { 1, 2 }));

            Console.WriteLine("shiftLeft");
            Console.WriteLine(shiftLeft(new int[] { 6, 2, 5, 3 }).SequenceEqual(new int[] { 2, 5, 3, 6 }));
            Console.WriteLine(shiftLeft(new int[] { 1, 2}).SequenceEqual(new int[] { 2, 1}));
            Console.WriteLine(shiftLeft(new int[] { 1 }).SequenceEqual(new int[] { 1 }));

            Console.WriteLine("tenRun");
            Console.WriteLine(tenRun(new int[] { 10, 1, 9, 20 }).SequenceEqual(new int[] { 10, 10, 10, 20 }));
            Console.WriteLine(tenRun(new int[] { 1 }).SequenceEqual(new int[] { 1 }));
            Console.WriteLine(tenRun(new int[] { }).SequenceEqual(new int[] { }));

            Console.WriteLine("pre4");
            Console.WriteLine(pre4(new int[] { 1, 2, 4, 1 }).SequenceEqual(new int[] { 1, 2 }));
            Console.WriteLine(pre4(new int[] { 3, 1, 4 }).SequenceEqual(new int[] { 3, 1 }));
            Console.WriteLine(pre4(new int[] { 1, 4, 4 }).SequenceEqual(new int[] { 1 }));
            Console.WriteLine(pre4(new int[] { 4, 4 }).SequenceEqual(new int[] { }));

            Console.WriteLine("pre4Linq");
            Console.WriteLine(pre4Linq(new int[] { 1, 2, 4, 1 }).SequenceEqual(new int[] { 1, 2 }));
            Console.WriteLine(pre4Linq(new int[] { 3, 1, 4 }).SequenceEqual(new int[] { 3, 1 }));
            Console.WriteLine(pre4Linq(new int[] { 1, 4, 4 }).SequenceEqual(new int[] { 1 }));
            Console.WriteLine(pre4Linq(new int[] { 4, 4 }).SequenceEqual(new int[] { }));

            Console.WriteLine("post4");
            Console.WriteLine(post4(new int[] { 2, 4, 1, 2}).SequenceEqual(new int[] { 1, 2}));
            Console.WriteLine(post4(new int[] { 4, 1, 4, 2}).SequenceEqual(new int[] { 2 }));
            Console.WriteLine(post4(new int[] { 4, 4, 1, 2, 3}).SequenceEqual(new int[] { 1, 2, 3}));
            Console.WriteLine(post4(new int[] { 4, 4}).SequenceEqual(new int[] { }));

            Console.WriteLine("post4Linq");
            Console.WriteLine(post4Linq(new int[] { 2, 4, 1, 2 }).SequenceEqual(new int[] { 1, 2 }));
            Console.WriteLine(post4Linq(new int[] { 4, 1, 4, 2 }).SequenceEqual(new int[] { 2 }));
            Console.WriteLine(post4Linq(new int[] { 4, 4, 1, 2, 3 }).SequenceEqual(new int[] { 1, 2, 3 }));
            Console.WriteLine(post4Linq(new int[] { 4, 4 }).SequenceEqual(new int[] { }));

            Console.WriteLine("zeroFront");
            Console.WriteLine(zeroFront(new int[] { 1, 0, 0, 1}).SequenceEqual(new int[] { 0, 0, 1, 1}));
            Console.WriteLine(zeroFront(new int[] { 0, 1, 1, 0, 1}).SequenceEqual(new int[] { 0, 0, 1, 1, 1}));
            Console.WriteLine(zeroFront(new int[] { 1, 0}).SequenceEqual(new int[] { 0, 1}));
            Console.WriteLine(zeroFront(new int[] { }).SequenceEqual(new int[] { }));

            Console.WriteLine("withoutTen");
            Console.WriteLine(withoutTen(new int[] { 1, 10, 10, 2}).SequenceEqual(new int[] { 1, 2, 0, 0}));
            Console.WriteLine(withoutTen(new int[] { 10, 2, 10}).SequenceEqual(new int[] { 2, 0, 0}));
            Console.WriteLine(withoutTen(new int[] { 1, 99, 10}).SequenceEqual(new int[] { 1, 99, 0}));
            Console.WriteLine(withoutTen(new int[] { }).SequenceEqual(new int[] { }));

            Console.WriteLine("zeroMax");
            Console.WriteLine(zeroMax(new int[] { 0, 5, 0, 2 }).SequenceEqual(new int[] { 5, 5, 0, 2}));
            Console.WriteLine(zeroMax(new int[] { 4, 0, 4, 3}).SequenceEqual(new int[] { 4, 3, 4, 3}));
            Console.WriteLine(zeroMax(new int[] { 0, 1, 0}).SequenceEqual(new int[] { 1, 1, 0}));

            Console.WriteLine("zeroMaxLinq");
            Console.WriteLine(zeroMaxLinq(new int[] { 0, 5, 0, 2 }).SequenceEqual(new int[] { 5, 5, 0, 2 }));
            Console.WriteLine(zeroMaxLinq(new int[] { 4, 0, 4, 3 }).SequenceEqual(new int[] { 4, 3, 4, 3 }));
            Console.WriteLine(zeroMaxLinq(new int[] { 0, 1, 0 }).SequenceEqual(new int[] { 1, 1, 0 }));

            Console.WriteLine("evenOdd");
            Console.WriteLine(evenOdd(new int[] { -1, 0, -1, 0, 0, -1 }).SequenceEqual(new int[] { 0, 0, 0, -1, -1, -1 }));
            Console.WriteLine(evenOdd(new int[] { 3, 3, 2 }).SequenceEqual(new int[] { 2, 3, 3 }));
            Console.WriteLine(evenOdd(new int[] { 2, 2, 2 }).SequenceEqual(new int[] { 2, 2, 2 }));

            Console.WriteLine("evenOddLinq");
            Console.WriteLine(evenOddLinq(new int[] { -1, 0, -1, 0, 0, -1 }).SequenceEqual(new int[] { 0, 0, 0, -1, -1, -1 }));
            Console.WriteLine(evenOddLinq(new int[] { 3, 3, 2 }).SequenceEqual(new int[] { 2, 3, 3 }));
            Console.WriteLine(evenOddLinq(new int[] { 2, 2, 2 }).SequenceEqual(new int[] { 2, 2, 2 }));

            Console.WriteLine("fizzBuzz");
            Console.WriteLine(fizzBuzz(1, 6).SequenceEqual(new string[] { "1", "2", "Fizz", "4", "Buzz"}));
            Console.WriteLine(fizzBuzz(1, 8).SequenceEqual(new string[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7"}));
            Console.WriteLine(fizzBuzz(1, 11).SequenceEqual(new string[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz"}));

            Console.WriteLine("fizzBuzzLinq");
            Console.WriteLine(fizzBuzzLinq(1, 6).SequenceEqual(new string[] { "1", "2", "Fizz", "4", "Buzz" }));
            Console.WriteLine(fizzBuzzLinq(1, 8).SequenceEqual(new string[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7" }));
            Console.WriteLine(fizzBuzzLinq(1, 11).SequenceEqual(new string[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz" }));

        }

        /*
        1. countEvens 
        Return the number of even ints in the given array. 

        countEvens({2, 1, 2, 3, 4}) → 3
        countEvens({2, 2, 0}) → 3
        countEvens({1, 3, 5}) → 0
        */
        public static int countEvens(int[] nums)
        {
            int count = 0;

            foreach (int n in nums)
                if (n % 2 == 0)
                    count++;

            return count;
        }

        /*
        Return the number of even ints in the given array. 
        Use Linq. Do not use loops.

        countEvensLinq({2, 1, 2, 3, 4}) → 3
        countEvensLinq({2, 2, 0}) → 3
        countEvensLinq({1, 3, 5}) → 0
        */
        public static int countEvensLinq(int[] nums)
        {
            return nums.Where(a => a % 2 == 0).Count();
        }

        /*
        2. bigDiff 
        Given an array length 1 or more of ints, return the difference between 
        the largest and smallest values in the array.

        bigDiff({10, 3, 5, 6}) → 7
        bigDiff({7, 2, 10, 9}) → 8
        bigDiff({2, 10, 7, 2}) → 8
        */
        public static int bigDiff(int[] nums)
        {
            int max = nums[0];
            int min = nums[0];

            foreach (int n in nums)
            {
                if (n > max)
                    max = n;
                if (n < min)
                    min = n;
            }

            return max - min;
        }


        /*
        Given an array length 1 or more of ints, return the difference between 
        the largest and smallest values in the array. Use Linq. Do not use loops.

        bigDiffLinq({10, 3, 5, 6}) → 7
        bigDiffLinq({7, 2, 10, 9}) → 8
        bigDiffLinq({2, 10, 7, 2}) → 8
        */
        public static int bigDiffLinq(int[] nums)
        {
            return nums.Max() - nums.Min();
        }

        /*
        3. centeredAverage 
        Return the "centered" average of an array of ints, which we'll say is the mean average 
        of the values, except ignoring the largest and smallest values in the array. If there 
        are multiple copies of the smallest value, ignore just one copy, and likewise for the 
        largest value. Use int division to produce the final average. You may assume that the 
        array is length 3 or more. 

        centeredAverage({1, 2, 3, 4, 100}) → 3
        centeredAverage({1, 1, 5, 5, 10, 8, 7}) → 5
        centeredAverage({-10, -4, -2, -4, -2, 0}) → -3
        */
        public static int centeredAverage(int[] nums)
        {
            int max = nums[0];
            int min = nums[0];
            int sum = 0;

            foreach (int n in nums)
            { 
                if (n > max)
                    max = n;
                if (n < min)
                    min = n;
                sum += n;
            }

            return (sum - max - min) / (nums.Length - 2);
        }

        /*
        Return the "centered" average of an array of ints, which we'll say is the mean average 
        of the values, except ignoring the largest and smallest values in the array. If there 
        are multiple copies of the smallest value, ignore just one copy, and likewise for the 
        largest value. Use int division to produce the final average. You may assume that the 
        array is length 3 or more. Use Linq. Do not use loops.

        centeredAverageLinq({1, 2, 3, 4, 100}) → 3
        centeredAverageLinq({1, 1, 5, 5, 10, 8, 7}) → 5
        centeredAverageLinq({-10, -4, -2, -4, -2, 0}) → -3
        */
        public static int centeredAverageLinq(int[] nums)
        {
            return (nums.Sum() - nums.Max() - nums.Min()) / (nums.Length - 2);
        }

        /*
        4. sum13
        Return the sum of the numbers in the array, returning 0 for an empty array. 
        Do not count elements matching the numberToSkip and if alsoSkipTrailing is 
        true then skip any element immediately following the numberToSkip.

        sum13({13, 2, 1, 2, 2, 1}, 13, true) → 6
        sum13({13, 13, 2, 1, 1}, 13, true) → 2
        sum13({1, 2, 2, 1, 13}, 13, true) → 6
        */
        public static int sum13(int[] nums, int numberToSkip, bool alsoSkipTrailing)
        {
            int sum = 0;
            for(int i = 0; i < nums.Length; i++) {
                if (nums[i] != 13 && (i == 0 || nums[i-1] != 13))
                   sum += nums[i];
            }
            return sum;
        }


        /*
        Return the sum of the numbers in the array, returning 0 for an empty array. 
        Do not count elements matching the numberToSkip and if alsoSkipTrailing is 
        true then skip any element immediately following the numberToSkip.
        Use Linq. Do not use loops.
        sum13Linq({13, 2, 1, 2, 2, 1}, 13, true) → 6
        sum13Linq({13, 13, 2, 1, 1}, 13, true) → 2
        sum13Linq({1, 2, 2, 1, 13}, 13, true) → 6
        */
        public static int sum13Linq(int[] nums, int numberToSkip, bool alsoSkipTrailing)
        {
            if (alsoSkipTrailing)
                return nums.Where((value, index) => value != numberToSkip
                        && (index == 0 || nums[index - 1] != numberToSkip)).Sum();
            else
                return nums.Where(value => value != numberToSkip).Sum();
        }
        /*
        5. sum67 
        Return the sum of the numbers in the array, except ignore sections of numbers 
        starting with left and extending through the next right. 

        sum67({1, 2, 2}, 6, 7) → 5
        sum67({1, 2, 2, 6, 99, 99, 7}, 6, 7) → 5
        sum67({1, 1, 6, 7, 2}, 6, 7) → 4
        */
        public static int sum67(int[] nums, int left, int right)
        {
            bool active = true;
            int sum = 0;
            foreach (int n in nums)
            {
                if (n == left)
                    active = false;
                if (active)
                    sum += n;
                if (n == right)
                    active = true;
            }
            return sum;
        }

        /*
        Given an array of ints, return true if the array contains 
        left followed immediately by right. 

        has22({1, 2, 2}, 2, 2) → true
        has22({1, 2, 1, 2}, 2, 2) → false
        has22({2, 1, 2}, 2, 2) → false
        */
        public static bool has22(int[] nums, int left, int right)
        {
            for (int i = 1; i < nums.Length; i++)
                if (nums[i - 1] == left && nums[i] == right)
                    return true;

            return false;
        }

        /*
        Given an array of ints, return true if the array contains 
        left followed immediately by right. Use Linq. Do not use loops.

        has22Linq({1, 2, 2}, 2, 2) → true
        has22Linq({1, 2, 1, 2}, 2, 2) → false
        has22Linq({2, 1, 2}, 2, 2) → false
        */
        public static bool has22Linq(int[] nums, int left, int right)
        {
            return nums.Skip(1)
                .Where((value, index) => nums[index] == left && value == right)
                .Any();
        }

        /*
        7. lucky13 

        Given an array of ints, return true if the array contains no elements 
        matching first and no elements matching second. 

        lucky13({0, 2, 4}, 1, 3) → true
        lucky13({1, 2, 3}, 1, 3) → false
        lucky13({1, 2, 4}, 1, 3) → false
        */
        public static bool lucky13(int[] nums, int first, int second)
        {
            return !nums.Contains(first) && !nums.Contains(second);
        }

        /*
        8. sum28 

        Given an array of ints, return true if the sum of all the numberToSum 
        in the array is exactly equal to target. 

        sum28({2, 3, 2, 2, 4, 2}, 2, 8) → true
        sum28({2, 3, 2, 2, 4, 2, 2}, 2, 8) → false
        sum28({1, 2, 3, 4}, 2, 8) → false
        */
        public static bool sum28(int[] nums, int numberToSum, int target)
        {
            int sum = 0;
            foreach (int n in nums)
                if (n == numberToSum)
                    sum += n;

            return sum == target;
        }

        /*
        Given an array of ints, return true if the sum of all the numberToSum 
        in the array is exactly equal to target. Use Linq. Do not use loops.

        sum28Linq({2, 3, 2, 2, 4, 2}, 2, 8) → true
        sum28Linq({2, 3, 2, 2, 4, 2, 2}, 2, 8) → false
        sum28Linq({1, 2, 3, 4}, 2, 8) → false
        */
        public static bool sum28Linq(int[] nums, int numberToSum, int target)
        {
            return nums.Where(i => i == numberToSum).Sum() == target;
        }

        /*
        9. more14 
        Given an array of ints, return true if the number of firsts is greater 
        than the number of seconds 

        more14({1, 4, 1}, 1, 4) → true
        more14({1, 4, 1, 4}, 1, 4) → false
        more14({1, 1}, 1, 4) → true
        */
        public static bool more14(int[] nums, int first, int second)
        {
            int countF = 0;
            int countS = 0;

            foreach (int n in nums)
            { 
                if (n == first)
                    countF++;
                else if (n == second)
                    countS++;
            }

            return countF > countS;
        }

        /*
        Given an array of ints, return true if the number of firsts is greater 
        than the number of seconds. Use Linq. Do not use loops.

        more14Linq({1, 4, 1}, 1, 4) → true
        more14Linq({1, 4, 1, 4}, 1, 4) → false
        more14Linq({1, 1}, 1, 4) → true
        */
        public static bool more14Linq(int[] nums, int first, int second)
        {
            return nums.Where(value => value == first).Count()
                 > nums.Where(value => value == second).Count();
        }

        /*
        10. fizzArray 

        Given a number n, create and return a new int array of length n, containing 
        the numbers 0, 1, 2, ... n-1. The given n may be 0, in which case just return 
        a length 0 array.

        fizzArray(4) → {0, 1, 2, 3}
        fizzArray(1) → {0}
        fizzArray(10) → {0, 1, 2, 3, 4, 5, 6, 7, 8, 9}
        */
        public static int[] fizzArray(int n)
        {
            int[] result = new int[n];
            for (int i = 0; i < n; i++)
                result[i] = i;

            return result;
        }


        /*
        Given a number n, create and return a new int array of length n, containing 
        the numbers 0, 1, 2, ... n-1. The given n may be 0, in which case just return 
        a length 0 array. Use Linq. Do not use loops.

        fizzArrayLinq(4) → {0, 1, 2, 3}
        fizzArrayLinq(1) → {0}
        fizzArrayLinq(10) → {0, 1, 2, 3, 4, 5, 6, 7, 8, 9}
        */
        public static int[] fizzArrayLinq(int n)
        {
            return Enumerable.Range(0, n).ToArray();
        }

        /*
        11. only14
        Given an array of ints, return true if every element is a 1 or a 4. 

        only14({1, 4, 1, 4}) → true
        only14({1, 4, 2, 4}) → false
        only14({1, 1}) → true
        */
        public static bool only14(int[] nums) {
            foreach (int n in nums)
                if (n != 1 && n != 4)
                    return false;

            return true;
        }

        /*
        Given an array of ints, return true if every element is a 1 or a 4. 
        Use Linq. Do not use loops.
        only14Linq({1, 4, 1, 4}) → true
        only14Linq({1, 4, 2, 4}) → false
        only14Linq({1, 1}) → true
        */
        public static bool only14Linq(int[] nums)
        {
            return nums.Where(a => a == 1).Count()
                 + nums.Where(a => a == 4).Count()
                == nums.Length;
        }

        /*
        12. fizzArray2 
        Given a number n, create and return a new string array of length n, containing 
        the strings "0", "1" "2" .. through n-1. N may be 0, in which case just return 
        a length 0 array.

        fizzArray2(4) → {"0", "1", "2", "3"}
        fizzArray2(10) → {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"}
        fizzArray2(2) → {"0", "1"}
        */
        public static String[] fizzArray2(int n)
        {
            string[] result = new string[n];
            for (int i = 0; i < n; i++)
                result[i] = i.ToString();

            return result;
        }

        /*
        Given a number n, create and return a new string array of length n, containing 
        the strings "0", "1" "2" .. through n-1. N may be 0, in which case just return 
        a length 0 array. Use Linq. Do not use loops.

        fizzArray2Linq(4) → {"0", "1", "2", "3"}
        fizzArray2Linq(10) → {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"}
        fizzArray2Linq(2) → {"0", "1"}
        */
        public static String[] fizzArray2Linq(int n)
        {
            return Enumerable.Range(0, n)
                .Select(x => x.ToString())
                .ToArray();
        }

        /*
        13. no14

        Given an array of ints, return true if it contains no firsts and/or no seconds. 

        no14({1, 2, 3}, 1, 4) → true
        no14({1, 2, 3, 4}, 1, 4) → false
        no14({2, 3, 4}, 1, 4) → true
        */
        public static bool no14(int[] nums, int first, int second)
        {
            bool noFirst = true;
            bool noSecond = true;

            foreach (int n in nums)
            {
                if (n == first)
                    noFirst = false;
                if (n == second)
                    noSecond = false;
                if (!noFirst && !noSecond)
                    break;
            }

            return noFirst || noSecond;
        }

        /*
        Given an array of ints, return true if it contains no firsts and/or no seconds. 
        Use Linq. Do not use loops.
        no14Linq({1, 2, 3}, 1, 4) → true
        no14Linq({1, 2, 3, 4}, 1, 4) → false
        no14Linq({2, 3, 4}, 1, 4) → true
        */
        public static bool no14Linq(int[] nums, int first, int second)
        {
            return !nums.Where(value => value == first).Any()
                || !nums.Where(value => value == second).Any();
        }

        /*
        14. isEverywhere 

        We'll say that a value is "everywhere" in an array if for every pair of adjacent 
        elements in the array, at least one of the pair is that value. Return true if 
        the given value is everywhere in the array. 

        isEverywhere({1, 2, 1, 3}, 1) → true
        isEverywhere({1, 2, 1, 3}, 2) → false
        isEverywhere({1, 2, 1, 3, 4}, 1) → false
        */
        public static bool isEverywhere(int[] nums, int val) {
            if (nums == null || nums.Length == 0)
                return false;
            else
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] != val)
                    {
                        if (i < nums.Length - 1 && nums[i + 1] != val)
                            return false;

                        if (i > 0 && nums[i - 1] != val)
                            return false;
                    }
                }
                return true;
            }
        }

        /*
        We'll say that a value is "everywhere" in an array if for every pair of adjacent 
        elements in the array, at least one of the pair is that value. Return true if 
        the given value is everywhere in the array. Use Linq. Do not use loops.

        isEverywhereLinq({1, 2, 1, 3}, 1) → true
        isEverywhereLinq({1, 2, 1, 3}, 2) → false
        isEverywhereLinq({1, 2, 1, 3, 4}, 1) → false
        */
        public static bool isEverywhereLinq(int[] nums, int val)
        {
            return !nums.Skip(1)
                .Where((value, index) => value != val && nums[index] != val)
                .Any();
        }

        /*
        15. either24 

        Given an array of ints, return true if the array contains adjacent elements 
        containing first or adjacent elements containing second but not both.

        either24({1, 2, 2}, 2, 4) → true
        either24({4, 4, 1}, 2, 4) → true
        either24({4, 4, 1, 2, 2}, 2, 4) → false
        */
        public static bool either24(int[] nums, int first, int second)
        {
            return hasAdjacentLinq(nums, first) != hasAdjacentLinq(nums, second);
        }

        private static bool hasAdjacentLinq(int[] nums, int target)
        {
            return nums.Skip(1)
                .Where((value, index) => nums[index] == target && value == target)
                .Any();
        }

        /*
        16. matchUp 

        Given arrays nums1 and nums2 of the same length, for every element in nums1, 
        consider the corresponding element in nums2 (at the same index). Return the 
        count of the number of times that the two elements differ by 2 or less, 
        but are not equal. 

        matchUp({1, 2, 3}, {2, 3, 10}) → 2
        matchUp({1, 2, 3}, {2, 3, 5}) → 3
        matchUp({1, 2, 3}, {2, 3, 3}) → 2
        */
        public static int matchUp(int[] nums1, int[] nums2)
        {
            int count = 0;
            for (int i = 0; i < Math.Min(nums1.Length, nums2.Length); i++) {
                int diff = Math.Abs(nums1[i] - nums2[i]);
                if (diff == 1 || diff == 2)
                    count++;
            }
            return count;   
        }

        /*
        Given arrays nums1 and nums2 of the same length, for every element in nums1, 
        consider the corresponding element in nums2 (at the same index). Return the 
        count of the number of times that the two elements differ by 2 or less, 
        but are not equal. Use Linq. Do not use loops.

        matchUpLinq({1, 2, 3}, {2, 3, 10}) → 2
        matchUpLinq({1, 2, 3}, {2, 3, 5}) → 3
        matchUpLinq({1, 2, 3}, {2, 3, 3}) → 2
        */
        public static int matchUpLinq(int[] nums1, int[] nums2)
        {
            var diff = nums1.Zip(nums2, (a, b) => Math.Abs(a - b));
            var result = diff.Select(element => element > 0 && element <= 2);
            return result.Where(element => element == true).Count();
        }

        /*
        17. has77

        Given an array of ints, return true if the array contains two 7's next to 
        each other, or there are two 7's separated by one element, such as with {7, 1, 7}. 

        has77({1, 7, 7}) → true
        has77({1, 7, 1, 7}) → true
        has77({1, 7, 1, 1, 7}) → false
        */
        public static bool has77(int[] nums)
        {
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i - 1] == 7 && nums[i] == 7)
                    return true;
                else if (i > 1 && nums[i - 2] == 7 && (nums[i - 1] == 7 || nums[i] == 7))
                    return true;
        }

            return false;
        }

        /*
        Given an array of ints, return true if the array contains two 7's next to 
        each other, or there are two 7's separated by one element, such as with {7, 1, 7}. 
        Use Linq. Do not use loops.
        has77Linq({1, 7, 7}) → true
        has77Linq({1, 7, 1, 7}) → true
        has77Linq({1, 7, 1, 1, 7}) → false
        */
        public static bool has77Linq(int[] nums)
        {
            return
                nums.Skip(1).Where((value, index) => value == nums[index] && value == 7).Any()
             || nums.Skip(2).Where((value, index) => value == nums[index] && value == 7).Any();
        }

        /*
        18. has12

        Given an array of ints, return true if first is in the array  
        with second somewhere later in the array. 

        has12({1, 2, 1}, 1, 2) → true
        has12({3, 1, 2}, 1, 2) → true
        has12({3, 2, 1}, 1, 2) → false
        */
        public static bool has12(int[] nums, int first, int second)
        {
            int firstPos = Array.IndexOf(nums, first);
            int secondPos = Array.LastIndexOf(nums, second);
            return firstPos >= 0 && secondPos >= 0 && firstPos < secondPos;
        }

        /*
        19. modThree 

        Given an array of ints, return true if the array contains 
        either 3 even or 3 odd values all next to each other. 

        modThree({2, 1, 3, 5}) → true
        modThree({2, 1, 2, 5}) → false
        modThree({2, 4, 2, 5}) → true
        modThree({1}) → false
        modThree({}) → false
        */
        public static bool modThree(int[] nums)
        {
            if (nums == null || nums.Length < 3)
                return false;

            for (int i = 2; i < nums.Length; i++)
                if (nums[i - 2] % 2 == nums[i - 1] % 2 && nums[i - 2] % 2 == nums[i] % 2)
                    return true;

            return false;
        }

        /*
        Given an array of ints, return true if the array contains 
        either 3 even or 3 odd values all next to each other. 
        Use Linq. Do not use loops.
        modThreeLinq({2, 1, 3, 5}) → true
        modThreeLinq({2, 1, 2, 5}) → false
        modThreeLinq({2, 4, 2, 5}) → true
        modThreeLinq({1}) → false
        modThreeLinq({}) → false
        */
        public static bool modThreeLinq(int[] nums)
        {
            return nums.Where((value, index) => index >= 2 
                && nums[index] % 2 == nums[index - 1] % 2 
                && nums[index] % 2 == nums[index - 2] % 2)
                .Any();
        }

        /*
        20. haveThree 

        Given an array of ints, return true if the value 3 appears in the array exactly 3 times, 
        and no 3's are next to each other. 

        haveThree({3, 1, 3, 1, 3}) → true
        haveThree({3, 1, 3, 3}) → false
        haveThree({3, 4, 3, 3, 4}) → false
        */
        public static bool haveThree(int[] nums)
        {
            int count = 0;

            if (nums == null || nums.Length < 2)
                return false;

            for (int i = 0; i < nums.Length; i++)
            { 
                if (nums[i] == 3)
                {
                    count++;

                    if (i > 0 && nums[i - 1] == 3)
                        return false;
                    if (i < nums.Length - 1 && nums[i + 1] == 3)
                        return false;
                }
            }

            return count == 3;
        }

        /*
        Given an array of ints, return true if the value 3 appears in the array exactly 3 times, 
        and no 3's are next to each other. Use Linq. Do not use loops.

        haveThreeLinq({3, 1, 3, 1, 3}) → true
        haveThreeLinq({3, 1, 3, 3}) → false
        haveThreeLinq({3, 4, 3, 3, 4}) → false
        */
        public static bool haveThreeLinq(int[] nums)
        {
            return nums.Where(val => val == 3).Count() == 3
                && !hasAdjacentLinq(nums, 3);
        }

        /*
        21. twoTwo 
        Given an array of ints, return true if every 2 that appears in the array is next to another 2. 

        twoTwo({4, 2, 2, 3}) → true
        twoTwo({2, 2, 4}) → true
        twoTwo({2, 2, 4, 2}) → false
        */
        public static bool twoTwo(int[] nums)
        {
            bool hasLoneTwo = false;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 2)
                {
                    hasLoneTwo = true;

                    if (i > 0 && nums[i - 1] == 2)
                        hasLoneTwo = false;
                    else if (i < nums.Length - 1 && nums[i + 1] == 2)
                        hasLoneTwo = false;
                }

                if (hasLoneTwo)
                    return false;
            }

            return !hasLoneTwo;
        }

        /*
        Given an array of ints, return true if every 2 that appears in the array is next to another 2. 
        Use Linq. Do not use loops.
        twoTwoLinq({4, 2, 2, 3}) → true
        twoTwoLinq({2, 2, 4}) → true
        twoTwoLinq({2, 2, 4, 2}) → false
        */
        public static bool twoTwoLinq(int[] nums)
        {
            return !nums.Where((value, index) => value == 2
            && (index == 0 || nums[index - 1] != 2)
            && (index == nums.Length - 1 || nums[index + 1] != 2))
            .Any();
        }

        /*
        22. sameEnds 
        Return true if the group of N numbers at the start and end of the array are the same. 
        For example, with {5, 6, 45, 99, 13, 5, 6}, the ends are the same for n=0 and n=2, 
        and false for n=1 and n=3.  

        sameEnds({5, 6, 45, 99, 13, 5, 6}, 1) → false
        sameEnds({5, 6, 45, 99, 13, 5, 6}, 2) → true
        sameEnds({5, 6, 45, 99, 13, 5, 6}, 3) → false
        */
        public static bool sameEnds(int[] nums, int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (nums[i] != nums[i + nums.Length - n])
                    return false;
            }

            return true;
        }

        /*
        Return true if the group of N numbers at the start and end of the array are the same. 
        For example, with {5, 6, 45, 99, 13, 5, 6}, the ends are the same for n=0 and n=2, 
        and false for n=1 and n=3. Use Linq. Do not use loops.

        sameEndsLinq({5, 6, 45, 99, 13, 5, 6}, 1) → false
        sameEndsLinq({5, 6, 45, 99, 13, 5, 6}, 2) → true
        sameEndsLinq({5, 6, 45, 99, 13, 5, 6}, 3) → false
        */
        public static bool sameEndsLinq(int[] nums, int n)
        {
            return nums.Take(n).SequenceEqual(nums.Skip(nums.Length - n).Take(n));
        }

        /*
        23. tripleUp
        Return true if the array contains, somewhere, three increasing adjacent numbers 
        like .... 4, 5, 6, ... or 23, 24, 25. 

        tripleUp({1, 4, 5, 6, 2}) → true
        tripleUp({1, 2, 3}) → true
        tripleUp({1, 2, 4}) → false
        */
        public static bool tripleUp(int[] nums)
        {
            for (int i = 2; i < nums.Length; i++)
                if (nums[i] == nums[i - 1] + 1 && nums[i] == nums[i - 2] + 2)
                    return true;

            return false;
        }

        /*
        Return true if the array contains, somewhere, three increasing adjacent numbers 
        like .... 4, 5, 6, ... or 23, 24, 25. Use Linq. Do not use loops.

        tripleUpLinq({1, 4, 5, 6, 2}) → true
        tripleUpLinq({1, 2, 3}) → true
        tripleUpLinq({1, 2, 4}) → false
        */
        public static bool tripleUpLinq(int[] nums)
        {
            return nums.Skip(2)
                .Where((value, index) => value == nums[index] + 2
                                      && value == nums[index + 1] + 1).Any();
        }

        /*
        24. fizzArray3 
        Given start and end numbers, return a new array containing 
        the sequence of integers from start up to but not including end, 
        so start=5 and end=10 yields {5, 6, 7, 8, 9}. 

        fizzArray3(5, 10) → {5, 6, 7, 8, 9}
        fizzArray3(11, 18) → {11, 12, 13, 14, 15, 16, 17}
        fizzArray3(1, 3) → {1, 2}
        */
        public static int[] fizzArray3(int start, int end)
        {
            int[] result = new int[end - start];

            for (int i = 0; i < end - start; i++)
                result[i] = start + i;

            return result;
        }

        /*
        Given start and end numbers, return a new array containing 
        the sequence of integers from start up to but not including end, 
        so start=5 and end=10 yields {5, 6, 7, 8, 9}. Use Linq. Do not use loops.

        fizzArray3Linq(5, 10) → {5, 6, 7, 8, 9}
        fizzArray3Linq(11, 18) → {11, 12, 13, 14, 15, 16, 17}
        fizzArray3Linq(1, 3) → {1, 2}
        */
        public static int[] fizzArray3Linq(int start, int end)
        {
            return Enumerable.Range(start, end - start).ToArray();
        }

        /*
        25. shiftLeft 

        Return an array that is "left shifted" by one -- so {6, 2, 5, 3} returns {2, 5, 3, 6}. 

        shiftLeft({6, 2, 5, 3}) → {2, 5, 3, 6}
        shiftLeft({1, 2}) → {2, 1}
        shiftLeft({1}) → {1}
        */
        public static int[] shiftLeft(int[] nums)
        {
            if (nums == null || nums.Length < 2)
                return nums;
            else
            {
                List<int> list = nums.ToList();
                list.Add(nums[0]);
                list.RemoveAt(0);
                return list.ToArray();
            }
        }

        /*
        26. tenRun 

        For each multiple of 10 in the given array, change all the values following it 
        to be that multiple of numBase, until encountering another multiple of 10. 
        So ({2, 10, 3, 4, 20, 5}, 10) yields {2, 10, 10, 10, 20, 20}. 

        tenRun({2, 10, 3, 4, 20, 5}) → {2, 10, 10, 10, 20, 20}
        tenRun({10, 1, 20, 2}) → {10, 10, 20, 20}
        tenRun({10, 1, 9, 20}) → {10, 10, 10, 20}
        tenRun({1}) → {1}	    
        tenRun({}) → {}    

        */
        public static int[] tenRun(int[] nums)
        {
            const int sentinel = -1;
            int replacement = sentinel;
  
            for(int i = 0; i < nums.Length; i++){
                if (nums[i] % 10 == 0)
                    replacement = nums[i];
                else if (replacement != sentinel)
                    nums[i] = replacement;
            }
            return nums;
        }

        /*
        27. pre4 
        Given a non-empty array of ints, return a new array containing the elements 
        from the original array that come before the first 4 in the original array. 
        The original array will contain at least one 4. 
        
        pre4({1, 2, 4, 1}) → {1, 2}
        pre4({3, 1, 4}) → {3, 1}
        pre4({1, 4, 4}) → {1}
        pre4({4, 4}) → {}	    
        */
        public static int[] pre4(int[] nums)
        {
            List<int> list = new List<int>();
            int first4 = Array.IndexOf(nums, 4);

            for (int i = 0; i < first4; i++)
                list.Add(nums[i]);

            return list.ToArray();
        }

        /*
        Given a non-empty array of ints, return a new array containing the elements 
        from the original array that come before the first 4 in the original array. 
        The original array will contain at least one 4. Use Linq. Do not use loops.
        
        pre4Linq({1, 2, 4, 1}) → {1, 2}
        pre4Linq({3, 1, 4}) → {3, 1}
        pre4Linq({1, 4, 4}) → {1}
        pre4Linq({4, 4}) → {}	    
        */
        public static int[] pre4Linq(int[] nums)
        {
            return nums.TakeWhile(item => item != 4).ToArray();
        }

        /*
        28. post4 

        Given a non-empty array of ints, return a new array containing the elements 
        from the original array that come after the last 4 in the original array. 
        The original array will contain at least one 4. 

        post4({2, 4, 1, 2}) → {1, 2}
        post4({4, 1, 4, 2}) → {2}
        post4({4, 4, 1, 2, 3}) → {1, 2, 3}
        post4({4, 4}) → {}	    
        post4({4}) → {}	
        */
        public static int[] post4(int[] nums)
        {
            List<int> list = new List<int>();
            int last4 = Array.LastIndexOf(nums, 4);

            for (int i = last4 + 1; i < nums.Length; i++)
                list.Add(nums[i]);

            return list.ToArray();
        }

        /*
        Given a non-empty array of ints, return a new array containing the elements 
        from the original array that come after the last 4 in the original array. 
        The original array will contain at least one 4. Use Linq. Do not use loops.

        post4Linq({2, 4, 1, 2}) → {1, 2}
        post4Linq({4, 1, 4, 2}) → {2}
        post4Linq({4, 4, 1, 2, 3}) → {1, 2, 3}
        post4Linq({4, 4}) → {}	    
        post4Linq({4}) → {}	
        */
        public static int[] post4Linq(int[] nums)
        {
            int last4 = Array.LastIndexOf(nums, 4) + 1;
            return nums.Skip(last4).Take(nums.Length - last4).ToArray();
        }

        /*
        29. notAlone 

        We'll say that an element in an array is "alone" if there are values before and after it, 
        and those values are different from it. 
        Return a version of the given array where every instance of the given value which is alone 
        is replaced by whichever value to its left or right is larger. 

        notAlone({1, 2, 3}, 2) → {1, 3, 3}
        notAlone({1, 2, 3, 2, 5, 2}, 2) → {1, 3, 3, 5, 5, 2}
        notAlone({3, 4}, 3) → {3, 4}
        */
        public static int[] notAlone(int[] nums, int val)
        { 
            for(int i = 1; i < nums.Length - 1; i++)
            { 
                if (nums[i] != nums[i-1] && nums[i] != nums[i+1])
                    nums[i] = Math.Max(nums[i-1], nums[i+1]);
            }
            return nums;
        }

        /*
        30. zeroFront 

        Return an array that contains the exact same numbers as the given array, 
        but rearranged so that all the zeros are grouped at the start of the array. 
        The order of the non-zero numbers does not matter. 
        So {1, 0, 0, 1} becomes {0 ,0, 1, 1}. 

        zeroFront({1, 0, 0, 1}) → {0, 0, 1, 1}
        zeroFront({0, 1, 1, 0, 1}) → {0, 0, 1, 1, 1}
        zeroFront({1, 0}) → {0, 1}
        zeroFront({}) → {}	    
        */
        public static int[] zeroFront(int[] nums)
        {
            int[] result = new int[nums.Length];
            int rpos = result.Length - 1;

            foreach (int n in nums)
                if (n != 0)
                    result[rpos--] = n;

            return result;
        }

        /*
        Return an array that contains the exact same numbers as the given array, 
        but rearranged so that all the zeros are grouped at the start of the array. 
        The order of the non-zero numbers does not matter. Use Linq. Do not use loops.
        So {1, 0, 0, 1} becomes {0 ,0, 1, 1}. 

        zeroFrontLinq({1, 0, 0, 1}) → {0, 0, 1, 1}
        zeroFrontLinq({0, 1, 1, 0, 1}) → {0, 0, 1, 1, 1}
        zeroFrontLinq({1, 0}) → {0, 1}
        zeroFrontLinq({}) → {}	    
        */
        public static int[] zeroFrontLinq(int[] nums)
        {
            var nonzero = nums.Where(item => item != 0).ToList();
            List<int> result = new List<int>(nums.Length - nonzero.Count);
            result.AddRange(nonzero);
            return result.ToArray();
        }

        /*
        31. withoutTen 

        Return a version of the given array where all the 10's have been removed. 
        The remaining elements should shift left towards the start of the array as needed, 
        and the empty spaces a the end of the array should be 0. 
        So {1, 10, 10, 2} yields {1, 2, 0, 0}. 

        withoutTen({1, 10, 10, 2}) → {1, 2, 0, 0}
        withoutTen({10, 2, 10}) → {2, 0, 0}
        withoutTen({1, 99, 10}) → {1, 99, 0}
        withoutTen({}) → {}	{}	OK	    
        */
        public static int[] withoutTen(int[] nums)
        {
            int[] result = new int[nums.Length];
            int rpos = 0;

            foreach (int n in nums)
                if (n != 10)
                    result[rpos++] = n;

            return result;
        }

        /*
        Return a version of the given array where all the 10's have been removed. 
        The remaining elements should shift left towards the start of the array as needed, 
        and the empty spaces a the end of the array should be 0. Use Linq. Do not use loops.
        So {1, 10, 10, 2} yields {1, 2, 0, 0}. 

        withoutTenLinq({1, 10, 10, 2}) → {1, 2, 0, 0}
        withoutTenLinq({10, 2, 10}) → {2, 0, 0}
        withoutTenLinq({1, 99, 10}) → {1, 99, 0}
        withoutTenLinq({}) → {}	{}	OK	    
        */
        public static int[] withoutTenLinq(int[] nums)
        {
            List<int> nonTen = nums.Where(item => item != 10).ToList();
            List<int> zeroes = new List<int>(nums.Length - nonTen.Count);
            return nonTen.Concat(zeroes).ToArray();  // could use AddRange
        }

        /*
        32. zeroMax 

        Return a version of the given array where each zero value in the array is replaced 
        by the largest odd value to the right of the zero in the array. If there is no odd 
        value to the right of the zero, leave the zero as a zero. 

        zeroMax({0, 5, 0, 2}) → {5, 5, 0, 2}
        zeroMax({4, 0, 4, 3}) → {4, 3, 4, 3}
        zeroMax({0, 1, 0}) → {1, 1, 0}
        */
        public static int[] zeroMax(int[] nums)
        {
            for(int i = 0; i < nums.Length - 1; i++)
            { 
                if (nums[i] == 0)
                {
                    int max = 0;

                    for (int j = i + 1; j < nums.Length; j++)
                        if (nums[j] % 2 != 0 && nums[j] > max)
                            max = nums[j];

                    nums[i] = max;
                }
            }

            return nums;
        }

        /*
        Return a version of the given array where each zero value in the array is replaced 
        by the largest odd value to the right of the zero in the array. If there is no odd 
        value to the right of the zero, leave the zero as a zero. Use Linq. Do not use loops.

        zeroMaxLinq({0, 5, 0, 2}) → {5, 5, 0, 2}
        zeroMaxLinq({4, 0, 4, 3}) → {4, 3, 4, 3}
        zeroMaxLinq({0, 1, 0}) → {1, 1, 0}
        */
        public static int[] zeroMaxLinq(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    var odds = nums.Skip(i).Where(x => x % 2 == 1);
                    nums[i] = odds.Any() ? odds.Max() : 0;
                }
            }
            return nums;
        }

        /*
        33. evenOdd
        Return an array that contains the exact same numbers as the given array, 
        but rearranged so that all the even numbers come before all the odd numbers. 
        Other than that, the numbers can be in any order. 

        evenOdd({-1, 0, -1, 0, 0, -1}) → {0, 0, 0, -1, -1, -1}
        evenOdd({3, 3, 2}) → {2, 3, 3}
        evenOdd({2, 2, 2}) → {2, 2, 2}
        */
        public static int[] evenOdd(int[] nums)
        {
            int evenPos = 0;
            int oddPos = nums.Length - 1;
            int temp = 0;

            for (int i = 0; i < nums.Length; i++)
                if (evenPos == oddPos)
                    break;
                else if (nums[i] % 2 == 0)
                {
                    temp = nums[evenPos];
                    nums[evenPos] = nums[i];
                    nums[i] = temp;
                    evenPos++;
                }
                else
                {
                    temp = nums[oddPos];
                    nums[oddPos] = nums[i];
                    nums[i] = temp;
                    oddPos--;
                }

            return nums;
        }

        /*
        Return an array that contains the exact same numbers as the given array, 
        but rearranged so that all the even numbers come before all the odd numbers. 
        Other than that, the numbers can be in any order. Use Linq. Do not use loops.

        evenOddLinq({-1, 0, -1, 0, 0, -1}) → {0, 0, 0, -1, -1, -1}
        evenOddLinq({3, 3, 2}) → {2, 3, 3}
        evenOddLinq({2, 2, 2}) → {2, 2, 2}
        */
        public static int[] evenOddLinq(int[] nums)
        {
            var evens = nums.Where(item => item % 2 == 0).ToList();
            var odds = nums.Where(item => item % 2 != 0).ToList();
            evens.AddRange(odds);
            return evens.ToArray();
        }

        /*
        34. fizzBuzz 
        Consider the series of numbers beginning at start and running up to but not 
        including end, so for example start=1 and end=5 gives the series 1, 2, 3, 4. 
        Return a new String[] array containing the string form of these numbers, except 
        for multiples of 3, use "Fizz" instead of the number, for multiples of 5 use "Buzz", 
        and for multiples of both 3 and 5 use "FizzBuzz".

        fizzBuzz(1, 6) → {"1", "2", "Fizz", "4", "Buzz"}
        fizzBuzz(1, 8) → {"1", "2", "Fizz", "4", "Buzz", "Fizz", "7"}
        fizzBuzz(1, 11) → {"1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz"}
        */
        public static String[] fizzBuzz(int start, int end)
        {
            string[] result = new string[end - start];

            for (int i = start; i < end; i++)
                result[i - start] = fb(i);

            return result;

        }


        /*
        Consider the series of numbers beginning at start and running up to but not 
        including end, so for example start=1 and end=5 gives the series 1, 2, 3, 4. 
        Return a new String[] array containing the string form of these numbers, except 
        for multiples of 3, use "Fizz" instead of the number, for multiples of 5 use "Buzz", 
        and for multiples of both 3 and 5 use "FizzBuzz". Use Linq. Do not use loops.

        fizzBuzzLinq(1, 6) → {"1", "2", "Fizz", "4", "Buzz"}
        fizzBuzzLinq(1, 8) → {"1", "2", "Fizz", "4", "Buzz", "Fizz", "7"}
        fizzBuzzLinq(1, 11) → {"1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz"}
        */
        public static String[] fizzBuzzLinq(int start, int end)
        {
            return Enumerable.Range(start, end - start)
                .Select(x => fb(x))
                .ToArray();
        }

        private static String fb(int num)
        {
            if (num % 3 == 0 && num % 5 == 0)
                return "FizzBuzz";
            else if (num % 3 == 0)
                return "Fizz";
            else if (num % 5 == 0)
                return "Buzz";
            else
                return num.ToString();
        }


    }
}
