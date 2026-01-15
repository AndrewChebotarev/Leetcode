/*
3794. Reverse String Prefix

You are given a string s and an integer k.

Reverse the first k characters of s and return the resulting string.

Example 1:

Input: s = "abcd", k = 2

Output: "bacd"

Explanation:​​​​​​​

The first k = 2 characters "ab" are reversed to "ba". The final resulting string is "bacd".

Example 2:

Input: s = "xyz", k = 3

Output: "zyx"

Explanation:

The first k = 3 characters "xyz" are reversed to "zyx". The final resulting string is "zyx".

Example 3:

Input: s = "hey", k = 1

Output: "hey"

Explanation:

The first k = 1 character "h" remains unchanged on reversal. The final resulting string is "hey".

Constraints:

1 <= s.length <= 100
s consists of lowercase English letters.
1 <= k <= s.length
*/

namespace Reverse_String_Prefix
{
    public class Program
    {
        private static string s1 = "abcd";
        private static string s2 = "xyz";
        private static string s3 = "hey";

        private static int k1 = 2;
        private static int k2 = 3;
        private static int k3 = 1;
        public static void Main(string[] args)
        {
            Reverse_String_Prefix reverse_String_Prefix1 = new(s1, k1);
            Reverse_String_Prefix reverse_String_Prefix2 = new(s2, k2);
            Reverse_String_Prefix reverse_String_Prefix3 = new(s3, k3);
        }
    }
}
