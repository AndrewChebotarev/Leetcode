namespace Maximum_Number_of_Words_Found_in_Sentences
{
    public class Maximum_Number_of_Words_Found_in_Sentences
    {
        private int maxNumberWords = 0;
        private int wordsInSentence = 0;

        public Maximum_Number_of_Words_Found_in_Sentences(string[] sentences)
        {
            foreach (string sentence in sentences)
            {
                GetWordsInSentence(sentence);
                CheckMaxNumberWords();
            }
            Console.WriteLine(maxNumberWords);
        }

        private void GetWordsInSentence(string sentence) => wordsInSentence = sentence.Split(new char[] { ' ' }).Length;

        private void CheckMaxNumberWords()
        {
            if (wordsInSentence > maxNumberWords) maxNumberWords = wordsInSentence;
        }
    }
}
