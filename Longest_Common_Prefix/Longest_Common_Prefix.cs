namespace Longest_Common_Prefix
{
    public class Longest_Common_Prefix
    {
        private string result = "";
        public Longest_Common_Prefix(string[] strs)
        {
            LongestCommonPrefix(strs);
            Console.WriteLine(result);
        }

        public string LongestCommonPrefix(string[] strs)
        {
            for (int i = 0; i < strs[0].Length; i++)
            {
                result += strs[0][i];

                for (int j = 1; j < strs.Length; j++)
                {
                    if (!strs[j].StartsWith(result))
                    {
                        result = result.Remove(result.Length - 1);
                        return result;
                    }
                }
            }

            return result;
        }
    }
}
