namespace Digit_Frequency_Score
{
    public class Digit_Frequency_Score
    {
        private int result = 0;
        private string nString = "";

        public Digit_Frequency_Score(int n)
        {
            nString = n.ToString();
            foreach (char sumbol in nString) result += int.Parse(sumbol.ToString());

            Console.WriteLine(result);
        }
    }
}
