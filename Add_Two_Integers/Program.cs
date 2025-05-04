/*
    2235. Add Two Integers

    Given two integers num1 and num2, return the sum of the two integers.
 
    Example 1:

    Input: num1 = 12, num2 = 5
    Output: 17
    Explanation: num1 is 12, num2 is 5, and their sum is 12 + 5 = 17, so 17 is returned.
    Example 2:

    Input: num1 = -10, num2 = 4
    Output: -6
    Explanation: num1 + num2 = -6, so -6 is returned.
 
    Constraints:

    -100 <= num1, num2 <= 100
 */

namespace Add_Two_Integers
{
    public class Program
    {
        private static int num1 = 12;
        private static int num2 = 5;

        private static int num3 = -10;
        private static int num4 = 4;

        public static void Main(string[] args)
        {
            Add_Two_Integers add_Two_Integers1 = new(num1, num2);
            Add_Two_Integers add_Two_Integers2 = new(num3, num4);
        }
    }
}
