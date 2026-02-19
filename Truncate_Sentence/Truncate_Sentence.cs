namespace Truncate_Sentence
{
    public class Truncate_Sentence
    {
        private string[] wordsArray;
        private string result = "";

        public Truncate_Sentence(string s, int k) 
        {
            GetWordsArray(s);
            FillResult(k);
            SubstringResult();

            Console.WriteLine(result);
        }

        private void GetWordsArray(string s) => wordsArray = s.Split(' ');

        private void FillResult(int k)
        {
            for (int index = 0; index < k; index++) result += wordsArray[index] + " ";
        }

        private void SubstringResult() => result = result.Substring(0, result.Length - 1);
    }
}