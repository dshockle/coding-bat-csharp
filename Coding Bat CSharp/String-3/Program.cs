using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace String_3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("countYZ");
            Console.WriteLine(countYZ("Why ask why? Indeed, why ask why!") == 4);
            Console.WriteLine(countYZ("day fez") == 2);
            Console.WriteLine(countYZ("day fyyyz") == 2);

            Console.WriteLine("withoutString");
            Console.WriteLine(withoutString("Hello there", "llo") == "He there");
            Console.WriteLine(withoutString("Hello there", "E") == "Hllo thr");
            Console.WriteLine(withoutString("Hello there", "X") == "Hello there");

            Console.WriteLine("equalIsNot");
            Console.WriteLine(equalIsNot("This is not", "is", "not") == false);
            Console.WriteLine(equalIsNot("This is not not", "is", "not") == true);
            Console.WriteLine(equalIsNot("Note the notice isn't.", "is", "not") == true);
            
            Console.WriteLine("gHappy");
            Console.WriteLine(gHappy("xxggxx", 'g') == true);
            Console.WriteLine(gHappy("xxgxx", 'g') == false);
            Console.WriteLine(gHappy("xxggyygxx", 'g') == false);

            Console.WriteLine("countTriple");
            Console.WriteLine(countTriple("abcXXXabc") == 1);
            Console.WriteLine(countTriple("xxxabyyyycd") == 3);
            Console.WriteLine(countTriple("a") == 0);

            Console.WriteLine("countTripleLinq");
            Console.WriteLine(countTripleLinq("abcXXXabc") == 1);
            Console.WriteLine(countTripleLinq("xxxabyyyycd") == 3);
            Console.WriteLine(countTripleLinq("a") == 0);

            Console.WriteLine("sumDigits");
            Console.WriteLine(sumDigits("aa1bc2d3") == 6);
            Console.WriteLine(sumDigits("aa11b33") == 8);
            Console.WriteLine(sumDigits("Chocolate") == 0);

            Console.WriteLine("sumDigitsLinq");
            Console.WriteLine(sumDigitsLinq("aa1bc2d3") == 6);
            Console.WriteLine(sumDigitsLinq("aa11b33") == 8);
            Console.WriteLine(sumDigitsLinq("Chocolate") == 0);

            Console.WriteLine("sameEnds");
            Console.WriteLine(sameEnds("abXYab") == "ab");
            Console.WriteLine(sameEnds("xx") == "x");
            Console.WriteLine(sameEnds("xxx") == "x");
            
            Console.WriteLine("mirrorEnds");
            Console.WriteLine(mirrorEnds("abXYZba") == "ab");
            Console.WriteLine(mirrorEnds("abca") == "a");
            Console.WriteLine(mirrorEnds("aba") == "aba");
            Console.WriteLine(mirrorEnds("dog") == "");
            
            Console.WriteLine("maxBlock");
            Console.WriteLine(maxBlock("hoopla") == 2);
            Console.WriteLine(maxBlock("abbCCCddBBBxx") == 3);
            Console.WriteLine(maxBlock("") == 0);
            Console.WriteLine(maxBlock("aaaa") == 4);
            
            Console.WriteLine("sumNumbers");
            Console.WriteLine(sumNumbers("abc123xyz") == 123);
            Console.WriteLine(sumNumbers("aa11b33") == 44);
            Console.WriteLine(sumNumbers("7 11") == 18);

            Console.WriteLine("sumNumbers");
            Console.WriteLine(notReplace("is test") == "is not test");
            Console.WriteLine(notReplace("is-is") == "is not-is not");
            Console.WriteLine(notReplace("This is right") == "This is not right");

        }



        /*
        Given a string, count the number of words ending in 'y' or 'z' -- so 
        the 'y' in "heavy" and the 'z' in "fez" count, but not the 'y' in "yellow" 
        (not case sensitive). We'll say that a y or z is at the end of a word if 
        there is not an alphabetic letter immediately following it. 
        
        countYZ("Why ask why? Indeed, why ask why!") → 4
        countYZ("day fez") → 2
        countYZ("day fyyyz") → 2
        */
        public static int countYZ(string str)
        {
            string input = Regex.Replace(str, @"[^\w\s]", "");
            string[] words = input.ToLower().Trim().Split();
            int count = 0;

            foreach (string word in words)
                if (word.EndsWith("y") || word.EndsWith("z"))
                    count++;

            return count;
        }

        /*
        Given two strings, original and remove, return a version of the original string 
        where all instances of the remove string have been removed (not case sensitive). 
        You may assume that the remove string is length 1 or more. 
        Remove only non-overlapping instances, so with "xxx" removing "xx" leaves "x". 

        withoutString("Hello there", "llo") → "He there"
        withoutString("Hello there", "e") → "Hllo thr"
        withoutString("Hello there", "x") → "Hello there"
        */
        public static string withoutString(string original, string remove)
        {
            return Regex.Replace(original, remove, "", RegexOptions.IgnoreCase);
        }

        /*
        Given a string, return true if the number of appearances of "first" anywhere 
        in the string is equal to the number of appearances of "second" anywhere in 
        the string (case sensitive). 

        equalIsNot("This is not.", "is", "not") → false
        equalIsNot("This is not not.", "is", "not") → true
        equalIsNot("Note the notice isn't.", "is", "not") → true
        */
        public static bool equalIsNot(string text, string first, string second)
        {
            int firstCount  = (text.Length - text.Replace(first, "").Length) / first.Length;
            int secondCount = (text.Length - text.Replace(second, "").Length) / second.Length;
            return firstCount == secondCount;
        }

        /*
        We'll say that a lowercase 'g' in a string is "happy" if there is another 'g' 
        immediately to its left or right. Return true if all the g's in the given string 
        are happy. 

        gHappy("xxggxx", 'g') → true
        gHappy("xxgxx", 'g') → false
        gHappy("xxggyygxx", 'g') → false
        */
        public static bool gHappy(string str, char g)
        {
            for(int i = 0; i < str.Length; i++)
                if (str[i] == g)
                    if ((i > 0 && str[i-1] != g)
                        && (i < str.Length - 1 && str[i + 1] != g))
                            return false;

            return true;
        }

        /*
        
        We'll say that a "triple" in a string is a char appearing three times in a row. 
        Return the number of triples in the given string. The triples may overlap. 

        countTriple("abcXXXabc") → 1
        countTriple("xxxabyyyycd") → 3
        countTriple("a") → 0
        */
        public static int countTriple(string str)
        {
            int count = 0;

            for (int i = 2; i < str.Length; i++)
                if (str[i] == str[i - 1] && str[i] == str[i - 2])
                    count++;

            return count;
        }

        /*
        
        We'll say that a "triple" in a string is a char appearing three times in a row. 
        Return the number of triples in the given string. The triples may overlap. 
        Use Linq. Do not use loops.
        countTripleLinq("abcXXXabc") → 1
        countTripleLinq("xxxabyyyycd") → 3
        countTripleLinq("a") → 0
        */
        public static int countTripleLinq(string str)
        {
            return str
                .Skip(2)
                .Where((ch, index) => ch == str[index] && ch == str[index + 1])
                .Count();
        }

        /*
        Given a string, return the sum of the digits 0-9 that appear in the string, 
        ignoring all other characters. Return 0 if there are no digits in the string. 

        sumDigits("aa1bc2d3") → 6
        sumDigits("aa11b33") → 8
        sumDigits("Chocolate") → 0
        */
        public static int sumDigits(string str)
        {
            int sum = 0;

            foreach (char c in str)
                if (char.IsDigit(c))
                    sum += (int)char.GetNumericValue(c);

            return sum;
        }

        /*
        Given a string, return the sum of the digits 0-9 that appear in the string, 
        ignoring all other characters. Return 0 if there are no digits in the string. 
        Use Linq. Do not use loops.
        sumDigitsLinq("aa1bc2d3") → 6
        sumDigitsLinq("aa11b33") → 8
        sumDigitsLinq("Chocolate") → 0
        */
        public static int sumDigitsLinq(string str)
        {
            return str.Where(c => Char.IsDigit(c))
                   .Select(digit => (int)char.GetNumericValue(digit))
                   .Sum();

        }


        /*
        Given a string, return the longest substring that appears at both the beginning and end 
        of the string without overlapping. For example, sameEnds("abXab") is "ab". 

        sameEnds("abXYab") → "ab"
        sameEnds("xx") → "x"
        sameEnds("xxx") → "x"
        */
        public static string sameEnds(string str)
        {
            int len = str.Length / 2;
            do
            {
                if (str.Substring(0, len) == str.Substring(str.Length - len))
                    return str.Substring(0, len);
                len--;
            } while (len > 0);

            return "";
        }

        /*
        Given a string, look for a mirror image (backwards) string at both the beginning 
        and end of the given string. In other words, zero or more characters at the very 
        begining of the given string, and at the very end of the string in reverse order 
        (possibly overlapping). For example, the string "abXYZba" has the mirror end "ab". 

        mirrorEnds("abXYZba") → "ab"
        mirrorEnds("abca") → "a"
        mirrorEnds("aba") → "aba"
        mirrorEnds("dog") → ""
        */
        public static string mirrorEnds(string str)
        {
            for(int i = 0; i < str.Length; i++)
                if (str[i] != str[str.Length - 1 - i])
                    return str.Substring(0, i);

            return str;
        }

        /*
        Given a string, return the length of the largest "block" in the string. 
        A block is a run of adjacent chars that are the same. 

        maxBlock("hoopla") → 2
        maxBlock("abbCCCddBBBxx") → 3
        maxBlock("") → 0
        maxBlock("aaaa") → 4
        */
        public static int maxBlock(string str)
        {
            int max = 0;
            for(int i = 0; i < str.Length; i++)
            {
                int block = 0;
                for(int j = i; j < str.Length; j++)
                {
                    if (str[i] != str[j])
                        break;
                    else
                        block = 1 + j - i;
                }
                if (block > max)
                    max = block;
            }
            return max;
        }

        /*
        Given a string, return the sum of the numbers appearing in the string, 
        ignoring all other characters. A number is a series of 1 or more digit 
        chars in a row. 

        sumNumbers("abc123xyz") → 123
        sumNumbers("aa11b33") → 44
        sumNumbers("7 11") → 18
        */
        public static int sumNumbers(string str)
        {
            if (String.IsNullOrWhiteSpace(str))
                return 0;

            string input = Regex.Replace(str, "[^0-9]", " ").Trim();
            string[] words = input.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            int sum = 0;
            int num = 0;

            foreach (string word in words)
            {
                if (int.TryParse(word, out num))
                    sum += num;
                else
                    num = 0;
            }
            return sum;
        }

        /*
        Given a string, return a string where every appearance of the lowercase word "is" 
        has been replaced with "is not". The word "is" should not be immediately preceeded 
        or followed by a letter -- so for example the "is" in "this" does not count. 

        notReplace("is test") → "is not test"
        notReplace("is-is") → "is not-is not"
        notReplace("This is right") → "This is not right"
        */
        public static string notReplace(string str)
        {
            return Regex.Replace(str, @"\bis\b", "is not");
        }

    }
}
