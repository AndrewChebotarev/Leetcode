/*  771. Jewels and Stones

    You're given strings jewels representing the types of stones that are jewels, and stones representing the stones you have. Each character in stones is a type of stone you have. You want to know how many of the stones you have are also jewels.

    Letters are case sensitive, so "a" is considered a different type of stone from "A".

    Example 1:

    Input: jewels = "aA", stones = "aAAbbbb"
    Output: 3
    Example 2:

    Input: jewels = "z", stones = "ZZ"
    Output: 0
 
    Constraints:

    1 <= jewels.length, stones.length <= 50
    jewels and stones consist of only English letters.
    All the characters of jewels are unique.
 */

namespace Jewels_and_Stones
{
    public class Program
    {
        private static string jewels1 = "aA";
        private static string stones1 = "aAAbbbb";

        private static string jewels2 = "z";
        private static string stones2 = "ZZ";

        private static void Main(string[] args)
        {
            Jewels_and_Stones jewels_And_Stones1 = new(jewels1, stones1);
            Jewels_and_Stones jewels_And_Stones2 = new(jewels2, stones2);
        }
    }
}
