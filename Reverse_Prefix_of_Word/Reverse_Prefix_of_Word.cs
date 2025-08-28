namespace Reverse_Prefix_of_Word
{
    public class Reverse_Prefix_of_Word
    {
        private string reverseNeedSymbols = "";
        public Reverse_Prefix_of_Word(string word, char ch)
        {
            if (word.Contains(ch))
            {
                int indexSymbolCh = word.IndexOf(ch);

                for (int i = indexSymbolCh; i != -1; i--)
                    reverseNeedSymbols += word[i];

                word = word.Remove(0, indexSymbolCh + 1);
                word = word.Insert(0, reverseNeedSymbols);

                Console.WriteLine(word);
            }
            else Console.WriteLine(word);
        }
    }
}
