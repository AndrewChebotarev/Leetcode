/*
    28. Find the Index of the First Occurrence in a String

    Given two strings needle and haystack, return the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.

    Example 1:

    Input: haystack = "sadbutsad", needle = "sad"
    Output: 0
    Explanation: "sad" occurs at index 0 and 6.
    The first occurrence is at index 0, so we return 0.
    Example 2:

    Input: haystack = "leetcode", needle = "leeto"
    Output: -1
    Explanation: "leeto" did not occur in "leetcode", so we return -1.
 
    Constraints:

    1 <= haystack.length, needle.length <= 104
    haystack and needle consist of only lowercase English characters
 */

namespace Find_the_Index_of_the_First_Occurrence_in_a_String
{
    public class Program
    {
        private static string haystack1 = "sadbutsad";
        private static string needle1 = "sad";

        private static string haystack2 = "leetcode";
        private static string needle2 = "leeto";
        public static void Main(string[] args)
        {
            Find_the_Index_of_the_First_Occurrence_in_a_String find_The_Index_Of_The_First_Occurrence_In_A_String1 = new(haystack1, needle1);
            Find_the_Index_of_the_First_Occurrence_in_a_String find_The_Index_Of_The_First_Occurrence_In_A_String2 = new(haystack2, needle2);
        }
    }
}
