/*58.
    Length of Last Word

    Given a string s consisting of words and spaces, return the length of the last word in the string.

    A word is a maximal substring consisting of non-space characters only.

    Example 1:

    Input: s = "Hello World"
    Output: 5
    Explanation: The last word is "World" with length 5.
    Example 2:

    Input: s = "   fly me   to   the moon  "
    Output: 4
    Explanation: The last word is "moon" with length 4.
    Example 3:

    Input: s = "luffy is still joyboy"
    Output: 6
    Explanation: The last word is "joyboy" with length 6.
 
    Constraints:

    1 <= s.length <= 104
    s consists of only English letters and spaces ' '.
    There will be at least one word in s.
 */

namespace Length_of_Last_Word
{
    public class Program
    {
        private const string s1 = "Hello World";
        private const string s2 = "   fly me   to   the moon  ";
        private const string s3 = "luffy is still joyboy";

        public static void Main(string[] args)
        {
            Length_of_Last_Word length_Of_Last_Word1 = new(s1);
            Length_of_Last_Word length_Of_Last_Word2 = new(s2);
            Length_of_Last_Word length_Of_Last_Word3 = new(s3);
        }
    }
}
