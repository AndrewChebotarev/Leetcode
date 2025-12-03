namespace Maximum_Substrings_With_Distinct_Start
{
    public class Maximum_Substrings_With_Distinct_Start
    {
        private List<char> kitCharList = new();
        public Maximum_Substrings_With_Distinct_Start(string s)
        {
            foreach (char symbol in s) if (!kitCharList.Contains(symbol)) kitCharList.Add(symbol);
            Console.WriteLine(kitCharList.Count);
        }
    }
}
