namespace Permutation_Difference_between_Two_Strings
{
    public class Permutation_Difference_between_Two_Strings
    {
        public int FindPermutationDifference(string s, string t)
        {
            int result = 0;

            for (int i = 0; i < s.Length; i++)
                for (int j = 0; j < t.Length; j++)
                    if (s[i] == t[j]) result += Math.Abs(i - j);

            return result;
        }
    }
}
