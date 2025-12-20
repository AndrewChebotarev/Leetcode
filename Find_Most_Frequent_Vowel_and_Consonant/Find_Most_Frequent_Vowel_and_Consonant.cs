namespace Find_Most_Frequent_Vowel_and_Consonant
{
    public class Find_Most_Frequent_Vowel_and_Consonant
    {
        private int vowelsCounter = 0;
        private int consonantsCounter = 0;
        private int result = 0;

        private int consonantsChar;

        public Find_Most_Frequent_Vowel_and_Consonant(string s)
        {
            foreach (char symbol in s)
            {
                if (symbol == 'a' || symbol == 'e' || symbol == 'i' || symbol == 'o' || symbol == 'u') ConsistingVowels(symbol, s);
                else ConsistingConsonants(symbol, s);
            }

            result = vowelsCounter + consonantsCounter;
            Console.WriteLine(result);
        }

        private void ConsistingVowels(char symbol, string s)
        {
            int vowelCounter = 0;

            foreach (char inSymbol in s) if (inSymbol == symbol) vowelCounter++;
            if (vowelsCounter < vowelCounter) vowelsCounter = vowelCounter;
        }

        private void ConsistingConsonants(char symbol, string s)
        {
            int consonantCounter = 0;

            consonantsChar = symbol;
            foreach (char inSymbol in s) if (consonantsChar == inSymbol) consonantCounter++;
            if (consonantsCounter < consonantCounter) consonantsCounter = consonantCounter;
        }
    }
}
