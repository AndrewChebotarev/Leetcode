/*
    1689. Partitioning Into Minimum Number Of Deci-Binary Numbers

    A decimal number is called deci-binary if each of its digits is either 0 or 1 without any leading zeros. For example, 101 and 1100 are deci-binary, while 112 and 3001 are not.
    Given a string n that represents a positive decimal integer, return the minimum number of positive deci-binary numbers needed so that they sum up to n.

    Example 1:

    Input: n = "32"
    Output: 3
    Explanation: 10 + 11 + 11 = 32
    Example 2:

    Input: n = "82734"
    Output: 8
    Example 3:

    Input: n = "27346209830709182346"
    Output: 9
 
    Constraints:

    1 <= n.length <= 105
    n consists of only digits.
    n does not contain any leading zeros and represents a positive integer.
*/

namespace Partitioning_Into_Minimum_Number_Of_Deci_Binary_Numbers
{
    public class Program
    {
        private static string number1 = "32";
        private static string number2 = "82734";
        private static string number3 = "27346209830709182346";

        public static void Main(string[] args)
        {
            Partitioning_Into_Minimum_Number_Of_Deci_Binary_Numbers partitioning_Into_Minimum_Number_Of_Deci_Binary_Numbers1 
                = new(number1);

            Partitioning_Into_Minimum_Number_Of_Deci_Binary_Numbers partitioning_Into_Minimum_Number_Of_Deci_Binary_Numbers2
                = new(number2);

            Partitioning_Into_Minimum_Number_Of_Deci_Binary_Numbers partitioning_Into_Minimum_Number_Of_Deci_Binary_Numbers3
                = new(number3);
        }
    }
}
