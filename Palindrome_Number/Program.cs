/*9. 
    Palindrome Number

    Given an integer x, return true if x is a palindrome, and false otherwise.

    Example 1:

    Input: x = 121
    Output: true
    Explanation: 121 reads as 121 from left to right and from right to left.
    Example 2:

    Input: x = -121
    Output: false
    Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.
    Example 3:

    Input: x = 10
    Output: false
    Explanation: Reads 01 from right to left. Therefore it is not a palindrome.

    Constraints:

    -231 <= x <= 231 - 1
 */

namespace Palindrome_Number
{
    public class Program
    {
        private static int x1 = 121;
        private static int x2 = -121;
        private static int x3 = 10;
        public static void Main(string[] args)
        {
            Palindrome_Number palindrome_Number1 = new(x1);
            Palindrome_Number palindrome_Number2 = new(x2);
            Palindrome_Number palindrome_Number3 = new(x3);
        }
    }
}
