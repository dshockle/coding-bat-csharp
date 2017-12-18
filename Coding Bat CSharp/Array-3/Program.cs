using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("maxSpan");
            Console.WriteLine(maxSpan(new int[] { 1, 2, 1, 1, 3 }) == 4);
            Console.WriteLine(maxSpan(new int[] { 1, 4, 2, 1, 4, 1, 4}) == 6);
            Console.WriteLine(maxSpan(new int[] { 1, 4, 2, 1, 4, 4, 4}) == 6);

            Console.WriteLine("maxSpanLinq");
            Console.WriteLine(maxSpan(new int[] { 1, 2, 1, 1, 3 }) == 4);
            Console.WriteLine(maxSpan(new int[] { 1, 4, 2, 1, 4, 1, 4 }) == 6);
            Console.WriteLine(maxSpan(new int[] { 1, 4, 2, 1, 4, 4, 4 }) == 6);

            Console.WriteLine("fix34");
            Console.WriteLine(fix34(new int[] { 1, 3, 1, 4 }).SequenceEqual(new int[] { 1, 3, 4, 1 }));
            Console.WriteLine(fix34(new int[] { 1, 3, 1, 4, 4, 3, 1}).SequenceEqual(new int[] { 1, 3, 4, 1, 1, 3, 4}));
            Console.WriteLine(fix34(new int[] { 3, 2, 2, 4}).SequenceEqual(new int[] { 3, 4, 2, 2}));

            Console.WriteLine("fix45");
            Console.WriteLine(fix45(new int[] { 5, 4, 9, 4, 9, 5}).SequenceEqual(new int[] { 9, 4, 5, 4, 5, 9}));
            Console.WriteLine(fix45(new int[] { 1, 4, 1, 5}).SequenceEqual(new int[] { 1, 4, 5, 1}));
            Console.WriteLine(fix45(new int[] { 1, 4, 1, 5, 5, 4, 1}).SequenceEqual(new int[] { 1, 4, 5, 1, 1, 4, 5}));
            
            Console.WriteLine("canBalance");
            Console.WriteLine(canBalance(new int[] { 1, 1, 1, 2, 1}) == true);
            Console.WriteLine(canBalance(new int[] { 2, 1, 1, 2, 1}) == false);
            Console.WriteLine(canBalance(new int[] { 10, 10}) == true);
            
            Console.WriteLine("linearIn");
            Console.WriteLine(linearIn(new int[] { 1, 2, 4, 6}, new int[] { 2, 4}) == true);
            Console.WriteLine(linearIn(new int[] { 1, 2, 4, 6}, new int[] { 2, 3, 4}) == false);
            Console.WriteLine(linearIn(new int[] { 1, 2, 4, 4, 6}, new int[] { 2, 4}) == true);

            Console.WriteLine("linearInLinq");
            Console.WriteLine(linearIn(new int[] { 1, 2, 4, 6 }, new int[] { 2, 4 }) == true);
            Console.WriteLine(linearIn(new int[] { 1, 2, 4, 6 }, new int[] { 2, 3, 4 }) == false);
            Console.WriteLine(linearIn(new int[] { 1, 2, 4, 4, 6 }, new int[] { 2, 4 }) == true);

            Console.WriteLine("squareUp");
            Console.WriteLine(squareUp(3).SequenceEqual(new int[] { 0, 0, 1, 0, 2, 1, 3, 2, 1 }));
            Console.WriteLine(squareUp(2).SequenceEqual(new int[] { 0, 1, 2, 1}));
            Console.WriteLine(squareUp(4).SequenceEqual(new int[] { 0, 0, 0, 1, 0, 0, 2, 1, 0, 3, 2, 1, 4, 3, 2, 1}));
            
            Console.WriteLine("seriesUp");
            Console.WriteLine(seriesUp(3).SequenceEqual(new int[] { 1, 1, 2, 1, 2, 3}));
            Console.WriteLine(seriesUp(4).SequenceEqual(new int[] { 1, 1, 2, 1, 2, 3, 1, 2, 3, 4}));
            Console.WriteLine(seriesUp(2).SequenceEqual(new int[] { 1, 1, 2}));

            Console.WriteLine("maxMirror");
            Console.WriteLine(maxMirror(new int[] { 1, 2, 3, 8, 9, 3, 2, 1 }) == 3);
            Console.WriteLine(maxMirror(new int[] { 1, 2, 1, 4}) == 3);
            Console.WriteLine(maxMirror(new int[] { 7, 1, 2, 9, 7, 2, 1}) == 2);

            Console.WriteLine("countClumps");
            Console.WriteLine(countClumps(new int[] { 1, 2, 2, 3, 4, 4 }) == 2);
            Console.WriteLine(countClumps(new int[] { 1, 1, 2, 1, 1}) == 2);
            Console.WriteLine(countClumps(new int[] { 1, 1, 1, 1, 1}) == 1);

            Console.WriteLine("countClumpsLinq");
            Console.WriteLine(countClumps(new int[] { 1, 2, 2, 3, 4, 4 }) == 2);
            Console.WriteLine(countClumps(new int[] { 1, 1, 2, 1, 1 }) == 2);
            Console.WriteLine(countClumps(new int[] { 1, 1, 1, 1, 1 }) == 1);

        }

        /*
        Consider the leftmost and righmost appearances of some value in an array. 
        We'll say that the "span" is the number of elements between the two inclusive. 
        A single value has a span of 1. Returns the largest span found in the given array. 

        maxSpan({1, 2, 1, 1, 3}) → 4
        maxSpan({1, 4, 2, 1, 4, 1, 4}) → 6
        maxSpan({1, 4, 2, 1, 4, 4, 4}) → 6
        */
        public static int maxSpan(int[] nums)
        {
            int max = 0;
            var set = nums.Distinct();
            foreach (int val in set)
            {
                int left = Array.IndexOf<int>(nums, val);
                int right = Array.LastIndexOf<int>(nums, val);
                int span = 1 + right - left;

                if (span > max)
                    max = span;
            }
            return max;
        }

        /*
        Consider the leftmost and righmost appearances of some value in an array. 
        We'll say that the "span" is the number of elements between the two inclusive. 
        A single value has a span of 1. Returns the largest span found in the given array. 
        Use Linq. Do not use loops.
        maxSpan({1, 2, 1, 1, 3}) → 4
        maxSpan({1, 4, 2, 1, 4, 1, 4}) → 6
        maxSpan({1, 4, 2, 1, 4, 4, 4}) → 6
        */
        public static int maxSpanLinq(int[] nums)
        {
            return nums
                  .Select((val) =>
                  1 + Array.LastIndexOf<int>(nums, val)
                  - Array.IndexOf<int>(nums, val))
                  .Max();
        }

        /*
        Return an array that contains exactly the same numbers as the given array, 
        but rearranged so that every 3 is immediately followed by a 4. 
        Do not move the 3's, but every other number may move. 
        The array contains the same number of 3's and 4's, every 3 has a number 
        after it that is not a 3 or 4, and a 3 appears in the array before any 4. 

        fix34({1, 3, 1, 4}) → {1, 3, 4, 1}
        fix34({1, 3, 1, 4, 4, 3, 1}) → {1, 3, 4, 1, 1, 3, 4}
        fix34({3, 2, 2, 4}) → {3, 4, 2, 2}
        */
        public static int[] fix34(int[] nums)
        {
            for(int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == 3 && nums[i + 1] != 4)
                {
                    for(int j = 0; j < nums.Length; j++)
                    {
                        if (nums[j] == 4 && (j == 0 || nums[j - 1] != 3))
                        {
                            nums[j] = nums[i + 1];
                            nums[i + 1] = 4;
                        }
                    }
                }
            }
            return nums;
        }

        /*
        (This is a slightly harder version of the fix34 problem.) 
        Return an array that contains exactly the same numbers as the given array, 
        but rearranged so that every 4 is immediately followed by a 5. 
        Do not move the 4's, but every other number may move. 
        The array contains the same number of 4's and 5's, and every 4 has a number 
        after it that is not a 4. In this version, 5's may appear anywhere in the 
        original array. 

        fix45({5, 4, 9, 4, 9, 5}) → {9, 4, 5, 4, 5, 9}
        fix45({1, 4, 1, 5}) → {1, 4, 5, 1}
        fix45({1, 4, 1, 5, 5, 4, 1}) → {1, 4, 5, 1, 1, 4, 5}
        */
        public static int[] fix45(int[] nums)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == 4 && nums[i + 1] != 5)
                {
                    for (int j = 0; j < nums.Length; j++)
                    {
                        if (nums[j] == 5 && (j == 0 || nums[j - 1] != 4))
                        {
                            nums[j] = nums[i + 1];
                            nums[i + 1] = 5;
                        }
                    }
                }
            }
            return nums;
        }

        /*
        Given a non-empty array, return true if there is a place to split the array 
        so that the sum of the numbers on one side is equal to the sum of the numbers 
        on the other side. 

        canBalance({1, 1, 1, 2, 1}) → true
        canBalance({2, 1, 1, 2, 1}) → false
        canBalance({10, 10}) → true
        */
        public static bool canBalance(int[] nums)
        {
            if (nums.Length < 2)
                return false;

            int pos = 0;
            int left = nums[pos];
            int right = nums.Sum() - nums[pos];

            while (left <= right && pos < nums.Length)
            {
                if (left == right)
                    return true;
                else 
                {
                    pos++;
                    left += nums[pos];
                    right -= nums[pos];
                }
            }
            return false;
        }

        /*
        Given two arrays of ints sorted in increasing order, outer and inner, 
        return true if all of the numbers in inner appear in outer. The best 
        solution makes only a single "linear" pass of both arrays, taking 
        advantage of the fact that both arrays are already in sorted order. 

        linearIn({1, 2, 4, 6}, {2, 4}) → true
        linearIn({1, 2, 4, 6}, {2, 3, 4}) → false
        linearIn({1, 2, 4, 4, 6}, {2, 4}) → true
        */
        public static bool linearIn(int[] outer, int[] inner)
        {
            HashSet<int> innerSet = new HashSet<int>(inner);

            foreach (int n in innerSet)
                if (!outer.Contains(n))
                    return false;

            return true;
        }

        /*
        Given two arrays of ints sorted in increasing order, outer and inner, 
        return true if all of the numbers in inner appear in outer. The best 
        solution makes only a single "linear" pass of both arrays, taking 
        advantage of the fact that both arrays are already in sorted order. 
        Use Linq. Do not use loops.
        linearInLinq({1, 2, 4, 6}, {2, 4}) → true
        linearInLinq({1, 2, 4, 6}, {2, 3, 4}) → false
        linearInLinq({1, 2, 4, 4, 6}, {2, 4}) → true
        */
        public static bool linearInLinq(int[] outer, int[] inner)
        {
            return outer.Intersect(inner).Count() == inner.Distinct().Count();
        }

        /*
        Given n >= 0, create an array length n * n with the following pattern, 
        shown here for n=3 : {0, 0, 1,    0, 2, 1,    3, 2, 1} 
        (spaces added to show the 3 groups). 

        squareUp(3) → {0, 0, 1, 0, 2, 1, 3, 2, 1}
        squareUp(2) → {0, 1, 2, 1}
        squareUp(4) → {0, 0, 0, 1, 0, 0, 2, 1, 0, 3, 2, 1, 4, 3, 2, 1}
        */
        public static int[] squareUp(int n)
        {
            int[] result = new int[n * n];
            int limit = n;
            int pos = result.Length - 1;
            int val = 1;

            while (pos >= 0)
            {
                result[pos] = val <= limit ? val : 0;
                pos--;
                val++;

                if (val > n)
                {
                    val = 1;
                    limit--;
                }
            }
            return result;
        }

        /*
        Given n >= 0, create an array with the pattern 
        {1,    1, 2,    1, 2, 3,   ... 1, 2, 3 .. n} (spaces added to show the grouping). 
        Note that the length of the array will be n*(n + 1)/2. 

        seriesUp(3) → {1, 1, 2, 1, 2, 3}
        seriesUp(4) → {1, 1, 2, 1, 2, 3, 1, 2, 3, 4}
        seriesUp(2) → {1, 1, 2}
        */

        public static int[] seriesUp(int n)
        {
            int[] result = new int[n * (n + 1) / 2];
            int limit = 1;
            int val = 1;

            for(int i = 0; i < result.Length; i++)
            {
                result[i] = val++;
                if (val > limit)
                {
                    val = 1;
                    limit++;
                }
            }

            return result;
        }



        /*
        We'll say that a "mirror" section in an array is a group of contiguous elements 
        such that somewhere in the array, the same group appears in reverse order. 
        For example, the largest mirror section in {1, 2, 3, 8, 9, 3, 2, 1} 
        is length 3 (the {1, 2, 3} part). Return the size of the largest mirror section 
        found in the given array. 

        maxMirror({1, 2, 3, 8, 9, 3, 2, 1}) → 3
        maxMirror({1, 2, 1, 4}) → 3
        maxMirror({7, 1, 2, 9, 7, 2, 1}) → 2
        */
        public static int maxMirror(int[] nums)
        {
            int max = 0;
            for(int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = nums.Length - 1; j > i; j--)
                {
                    if (nums[i] == nums[j])
                    {
                        int left = i;
                        int right = j;
                        int span = 0;

                        while (nums[left] == nums[right] && left < nums.Length && right > 0)
                        {
                            span++;
                            left++;
                            right--;
                        }

                        if (left >= right)
                            span++;

                        if (span > max)
                            max = span;
                    }
                }
            }
            return max;
        }

        /*
        Say that a "clump" in an array is a series of 2 or more adjacent elements of the same value. 
        Return the number of clumps in the given array. 

        countClumps({1, 2, 2, 3, 4, 4}) → 2
        countClumps({1, 1, 2, 1, 1}) → 2
        countClumps({1, 1, 1, 1, 1}) → 1
        */
        public static int countClumps(int[] nums)
        {
            int count = 0;
            bool inClump = false;

            for(int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == nums[i - 1])
                {
                    if (!inClump)
                    {
                        count++;
                        inClump = true;
                    }
                }
                else
                    inClump = false;
            }
            return count;
        }

        /*
        Say that a "clump" in an array is a series of 2 or more adjacent elements of the same value. 
        Return the number of clumps in the given array. Use Linq. Do not use loops.

        countClumpsLinq({1, 2, 2, 3, 4, 4}) → 2
        countClumpsLinq({1, 1, 2, 1, 1}) → 2
        countClumpsLinq({1, 1, 1, 1, 1}) → 1
        */
        public static int countClumpsLinq(int[] nums)
        {
            return nums.Skip(1)
                       .Where((value, index) => value == nums[index + 1] && value != nums[index])
                       .Count();
        }
    }
}
