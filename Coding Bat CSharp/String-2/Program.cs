using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace String_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("doubleChar");
            Console.WriteLine(doubleChar("The") == "TThhee");
            Console.WriteLine(doubleChar("AAbb") == "AAAAbbbb");
            Console.WriteLine(doubleChar("Hi-There") == "HHii--TThheerree");

            Console.WriteLine("countHi");
            Console.WriteLine(countHi("ABChi hi") == 2);
            Console.WriteLine(countHi("abc hi ho") == 1);
            Console.WriteLine(countHi("hihi") == 2);

            Console.WriteLine("catDog");
            Console.WriteLine(catDog("catdog") == true);
            Console.WriteLine(catDog("catcat") == false);
            Console.WriteLine(catDog("1cat1cadodog") == true);

            Console.WriteLine("countCode");
            Console.WriteLine(countCode("aaacodebbb") == 1);
            Console.WriteLine(countCode("codexxcode") == 2);
            Console.WriteLine(countCode("cozexxcope") == 2);

            Console.WriteLine("endOther");
            Console.WriteLine(endOther("Hiabc", "abc") == true);
            Console.WriteLine(endOther("AbC", "HiaBc") == true);
            Console.WriteLine(endOther("abc", "abXabc") == true);

            Console.WriteLine("xyzThere");
            Console.WriteLine(xyzThere(".xyzabcxyz") == true);
            Console.WriteLine(xyzThere("abcxyz") == true);
            Console.WriteLine(xyzThere("abc.xyz") == false);
            Console.WriteLine(xyzThere("xyz.abc") == true);
         
            Console.WriteLine("bobThere");
            Console.WriteLine(bobThere("abcbob") == true);
            Console.WriteLine(bobThere("b9b") == true);
            Console.WriteLine(bobThere("bac") == false);

            Console.WriteLine("xyBalance");
            Console.WriteLine(xyBalance("aaxbby") == true);
            Console.WriteLine(xyBalance("aaxbb") == false);
            Console.WriteLine(xyBalance("yaaxbb") == false);

            Console.WriteLine("mixString");
            Console.WriteLine(mixString("abc", "xyz") == "axbycz");
            Console.WriteLine(mixString("Hi", "There") == "HTihere");
            Console.WriteLine(mixString("xxxx", "There") == "xTxhxexre");

            Console.WriteLine("repeatEnd");
            Console.WriteLine(repeatEnd("Hello", 2) == "lolo");
            Console.WriteLine(repeatEnd("Hello", 3) == "llollollo");
            Console.WriteLine(repeatEnd("Hello", 1) == "o");

            Console.WriteLine("repeatFront");
            Console.WriteLine(repeatFront("Chocolate", 4) == "ChocChoChC");
            Console.WriteLine(repeatFront("Chocolate", 3) == "ChoChC");
            Console.WriteLine(repeatFront("Ice Cream", 2) == "IcI");

            Console.WriteLine("repeatSeparator");
            Console.WriteLine(repeatSeparator("Word", "X", 3) == "WordXWordXWord");
            Console.WriteLine(repeatSeparator("This", "And", 2) == "ThisAndThis");
            Console.WriteLine(repeatSeparator("This", "And", 1) == "This");

            Console.WriteLine("prefixAgain");
            Console.WriteLine(prefixAgain("abXYabc", 1) == true);
            Console.WriteLine(prefixAgain("abXYabc", 2) == true);
            Console.WriteLine(prefixAgain("abXYabc", 3) == false);

            Console.WriteLine("subMiddle");
            Console.WriteLine(subMiddle("AAxyzB", "xyz") == true);
            Console.WriteLine(subMiddle("AxyzBB", "xyz") == true);
            Console.WriteLine(subMiddle("AxyzBBB", "xyz") == false);
          
            Console.WriteLine("getSandwich");
            Console.WriteLine(getSandwich("jellybreadjambreadbutter", "bread") == "jam");
            Console.WriteLine(getSandwich("breadjambread", "bread") == "jam");
            Console.WriteLine(getSandwich("xxbreadjambreadyy", "bread") == "jam");
            Console.WriteLine(getSandwich("xxbreadyy", "bread") == "");
          
            Console.WriteLine("sameStarChar");
            Console.WriteLine(sameStarChar("xy*yzz") == true);
            Console.WriteLine(sameStarChar("xy*zzz") == false);
            Console.WriteLine(sameStarChar("*xa*az") == true);

            Console.WriteLine("oneTwo");
            Console.WriteLine(oneTwo("tcax") == "cat");
            Console.WriteLine(oneTwo("abc") == "bca");
            Console.WriteLine(oneTwo("tcagdo") == "catdog");

            Console.WriteLine("zipZap");
            Console.WriteLine(zipZap("zipXzap") == "zpXzp");
            Console.WriteLine(zipZap("zopzop") == "zpzp");
            Console.WriteLine(zipZap("zzzopzop") == "zzzpzp");

            Console.WriteLine("starOut");
            Console.WriteLine(starOut("sm**eilly") == "silly");
            Console.WriteLine(starOut("ab*cd") == "ad");
            Console.WriteLine(starOut("ab**cd") == "ad");
            Console.WriteLine(starOut("sm**eilly") == "silly");

            Console.WriteLine("plusOut");
            Console.WriteLine(plusOut("12xy34xyabcxy", "xy") == "++xy++xy+++xy");
            Console.WriteLine(plusOut("12xy34", "xy") == "++xy++");
            Console.WriteLine(plusOut("12xy34", "1") == "1+++++");
            Console.WriteLine(plusOut("12xy34xyabcxy", "xy") == "++xy++xy+++xy");

            Console.WriteLine("wordEnds");
            Console.WriteLine(wordEnds("abcXY123XYijk", "XY") == "c13i");
            Console.WriteLine(wordEnds("XY1XY", "XY") == "11");
            Console.WriteLine(wordEnds("XY123XY", "XY") == "13");
            Console.WriteLine(wordEnds("XY1XY", "XY") == "11");


        }

        /*
        Given a string, return a string where for every char in the original, there are two chars. 

        doubleChar("The") → "TThhee"
        doubleChar("AAbb") → "AAAAbbbb"
        doubleChar("Hi-There") → "HHii--TThheerree"
        */
        public static string doubleChar(string str)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in str)
            {
                sb.Append(c);
                sb.Append(c);
            }
            return sb.ToString();
        }

        /*
        Return the number of times that the string "hi" appears 
        anywhere in the given string. 

        countHi("abc hi ho") → 1
        countHi("ABChi hi") → 2
        countHi("hihi") → 2
        */
        public static int countHi(string str)
        {
            return Regex.Matches(str, "hi").Count;
        }

        /*
        Return true if the string "cat" and "dog" appear 
        the same number of times in the given string. 

        catDog("catdog") → true
        catDog("catcat") → false
        catDog("1cat1cadodog") → true
        */
        public static bool catDog(string str)
        {
             return Regex.Matches(str, "cat").Count == Regex.Matches(str, "dog").Count;
        }

        /*
        Return the number of times that the string "code" appears anywhere in the given string, 
        except we'll accept any letter for the 'd', so "cope" and "cooe" count. 

        countCode("aaacodebbb") → 1
        countCode("codexxcode") → 2
        countCode("cozexxcope") → 2
        */
        public static int countCode(String str)
        {
            return Regex.Matches(str, "co.e").Count;
        }

        /*
        Given two strings, return true if either of the strings appears at the 
        very end of the other string, ignoring upper/lower case differences. 

        endOther("Hiabc", "abc") → true
        endOther("AbC", "HiaBc") → true
        endOther("abc", "abXabc") → true
        */
        public static bool endOther(string a, string b)
        {
            return a.EndsWith(b, StringComparison.CurrentCultureIgnoreCase) 
                || b.EndsWith(a, StringComparison.CurrentCultureIgnoreCase);
        }

        /*
        Return true if the given string contains an appearance of "xyz" where the xyz is 
        not directly preceeded by a period (.). So "xxyz" counts but "x.xyz" does not. 

        xyzThere("abcxyz") → true
        xyzThere("abc.xyz") → false
        xyzThere("xyz.abc") → true
        */
        public static bool xyzThere(string str)
        {
            return Regex.IsMatch(str, "^xyz|[^\\.]xyz");
        }

        /*
        Return true if the given string contains a "bob" string, 
        but where the middle 'o' char can be any char. 

        bobThere("abcbob") → true
        bobThere("b9b") → true
        bobThere("bac") → false
        */
        public static bool bobThere(string str)
        {
            return Regex.IsMatch(str, "b.b");
        }

        /*        
        Return true if  for all the 'x' chars in the string, there exists a 'y' 
        char somewhere later in the string. One 'y' can balance multiple 'x's. 

        xyBalance("aaxbby") → true
        xyBalance("aaxbb") → false
        xyBalance("yaaxbb") → false
        */
        public static bool xyBalance(string str)
        {
            return str.LastIndexOf("x", StringComparison.CurrentCultureIgnoreCase)
                <= str.LastIndexOf("y", StringComparison.CurrentCultureIgnoreCase);
        }

        /*
        Given two strings, a and b, create a bigger string made of the first char of a, 
        the first char of b, the second char of a, the second char of b, and so on. 
        Any leftover chars go at the end of the result. 

        mixString("abc", "xyz") → "axbycz"
        mixString("Hi", "There") → "HTihere"
        mixString("xxxx", "There") → "xTxhxexre"
        */
        public static string mixString(string a, string b)
        {
            StringBuilder sb = new StringBuilder();
            int min = Math.Min(a.Length, b.Length);
            int max = Math.Max(a.Length, b.Length);

            for (int i = 0; i < min; i++)
            {
                sb.Append(a[i]);
                sb.Append(b[i]);
            }

            if (max != min) 
                if (max == a.Length)
                    sb.Append(a.Substring(min));
                if (max == b.Length)
                    sb.Append(b.Substring(min));

            return sb.ToString();
        }

        /*
        Given a string and an int n, return a string made of n repetitions 
        of the last n characters of the string. You may assume that n is 
        between 0 and the length of the string, inclusive. 

        repeatEnd("Hello", 3) → "llollollo"
        repeatEnd("Hello", 2) → "lolo"
        repeatEnd("Hello", 1) → "o"
        */
        public static string repeatEnd(string str, int n)
        {
            return String.Concat(Enumerable.Repeat(str.Substring(str.Length - n), n));
        }

        /*
        Given a string and an int n, return a string made of the first n characters 
        of the string, followed by the first n-1 characters of the string, and so on. 

        repeatFront("Chocolate", 4) → "ChocChoChC"
        repeatFront("Chocolate", 3) → "ChoChC"
        repeatFront("Ice Cream", 2) → "IcI"
        */
        public static string repeatFront(string str, int n)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = n; i >= 0; i--)
            {
                sb.Append(str.Substring(0, i));
            }
            return sb.ToString();
        }

        /*
        Given two strings, word and a separator sep, return a big string 
        made of count occurrences of the word, separated by the separator string. 

        repeatSeparator("Word", "X", 3) → "WordXWordXWord"
        repeatSeparator("This", "And", 2) → "ThisAndThis"
        repeatSeparator("This", "And", 1) → "This"
        */
        public static string repeatSeparator(string word, string sep, int count)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                sb.Append(word);
                if (i < count - 1)
                    sb.Append(sep);
            }
            return sb.ToString();
        }

        /*
        Given a string, consider the prefix string made of the first N chars 
        of the string. Does that prefix string appear somewhere else in the string? 
        Assume that the string is not empty and that N is in the range 1..str.length(). 

        prefixAgain("abXYabc", 1) → true
        prefixAgain("abXYabc", 2) → true
        prefixAgain("abXYabc", 3) → false
        */
        public static bool prefixAgain(string str, int n)
        {
            return str.Substring(n).Contains(str.Substring(0, n));
        }

        /*
        Given a string, does the sub string appear in the middle of the string? 
        To define middle, we'll say that the number of chars to the left 
        and right of the sub string must differ by at most one. 
        This problem is harder than it looks. 

        subMiddle("AAxyzBB", "xyz") → true
        subMiddle("AxyzBB", "xyz") → true
        subMiddle("AAxyzB", "xyz") → true
        subMiddle("AxyzBBB", "xyz") → false
        */
        public static bool subMiddle(string str, string sub)
        {
            int strLen = str.Length;
            int subLen = sub.Length;
            bool oddPadding = (strLen - subLen) % 2 == 1;

            int startEven = strLen / 2 - subLen / 2;
            int startOdd = strLen / 2 - subLen / 2 - 1;

            string strEven = str.Substring(startEven, subLen);
            string strOdd = str.Substring(startOdd, subLen);

            bool resultEven = strEven.Equals(sub);
            bool resultOdd = strOdd.Equals(sub);

            return oddPadding ? resultEven || resultOdd : resultEven;
        }

        /*
        Return the string that is between the first and last appearance 
        of "bread" in the given string, or return the empty string "" if 
        there are not two pieces of bread. 

        getSandwich("breadjambread", "bread") → "jam"
        getSandwich("xxbreadjambreadyy", "bread") → "jam"
        getSandwich("xxbreadyy", "bread") → ""
        */
        public static string getSandwich(string str, string bread)
        {
            int first = str.IndexOf(bread);
            int last = str.LastIndexOf(bread);
            int start = first + bread.Length;

            if (first < 0 || start >= last)
                return "";
            else
                return str.Substring(start, last - start);
        }

        /*
        Returns true if for every '*' (star) in the string, if there are chars 
        both immediately before and after the star, they are the same. 

        sameStarChar("xy*yzz") → true
        sameStarChar("xy*zzz") → false
        sameStarChar("*xa*az") → true
        */
        public static bool sameStarChar(string str)
        {
            for(int i = 1; i < str.Length - 1; i++)
            {
                if (str[i] == '*')
                    if (str[i - 1] != str[i + 1])
                        return false;
            }
            return true;
        }

        /*
        Given a string, compute a new string by moving the first char to come 
        after the next two chars, so "abc" yields "bca". Repeat this process for 
        each subsequent group of 3 chars, so "abcdef" yields "bcaefd". 
        Ignore any group of fewer than 3 chars at the end. 

        oneTwo("abc") → "bca"
        oneTwo("tcax") → "cat"
        oneTwo("tcagdo") → "catdog"
        */
        public static string oneTwo(string str)
        {
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < str.Length - 2; i += 3)
            {
                sb.Append(str[i + 1]);
                sb.Append(str[i + 2]);
                sb.Append(str[i]);
            }
            return sb.ToString();
        }

        /*
        Look for patterns like "zip" and "zap" in the string -- length-3, 
        starting with 'z' and ending with 'p'. Return a string where for 
        all such words, the middle letter is gone, so "zipXzap" yields "zpXzp". 

        zipZap("zipXzap") → "zpXzp"
        zipZap("zopzop") → "zpzp"
        zipZap("zzzopzop") → "zzzpzp"
        */
        public static string zipZap(string str)
        {
            return Regex.Replace(str, "z.p", "zp");
        }

        /*
        Return a version of the given string, where for every star (*) in the 
        string the star and the chars immediately to its left and right are gone. 
        So "ab*cd" yields "ad" and "ab**cd" also yields "ad". 

        starOut("ab*cd") → "ad"
        starOut("ab**cd") → "ad"
        starOut("sm**eilly") → "silly"
        */
        public static string starOut(string str)
        {
            return Regex.Replace(str, ".\\*+.", "");
        }

        /*
        Given a string and a non-empty word string, return a version of the original 
        String where all chars have been replaced by pluses ("+"), except for appearances 
        of the word string which are preserved unchanged. 

        plusOut("12xy34", "xy") → "++xy++"
        plusOut("12xy34", "1") → "1+++++"
        plusOut("12xy34xyabcxy", "xy") → "++xy++xy+++xy"
        */
        public static string plusOut(string str, string word)
        {
            return Regex.Replace(str, @"[^" + word + "]", "+");
        }

        /*
        Given a string and a non-empty word string, return a string made of each char 
        just before and just after every appearance of the word in the string. 
        Ignore cases where there is no char before or after the word, and a char may 
        be included twice if it is between two words. 

        wordEnds("abcXY123XYijk", "XY") → "c13i"
        wordEnds("XY123XY", "XY") → "13"
        wordEnds("XY1XY", "XY") → "11"
        */
        public static string wordEnds(string str, string word)
        {
            StringBuilder sb = new StringBuilder();
            MatchCollection matches = Regex.Matches(str, word);

            foreach (Match match in matches)
            {
                if (match.Index > 0 && match.Index < str.Length)
                    sb.Append(str[match.Index - 1]);

                if (match.Index + word.Length < str.Length)
                    sb.Append(str[match.Index + word.Length]);
            }
            return sb.ToString();
        }

    }
}
