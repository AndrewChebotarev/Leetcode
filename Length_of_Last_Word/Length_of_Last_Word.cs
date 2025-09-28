namespace Length_of_Last_Word
{
    public class Length_of_Last_Word
    {
        private string[]? words;
        private string? lastWord;

        public Length_of_Last_Word(string s) 
        {
            SetWords(s);
            SetLastWord();
            Console.WriteLine(lastWord?.Length.ToString());
        }

        private void SetWords(string s) => words = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        private void SetLastWord() => lastWord = words?.Last();
    }
}
