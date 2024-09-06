namespace Score_of_a_String
{
    public class Score_of_a_String
    {
        private int sum = 0;
        public Score_of_a_String(string s) 
        {
            for (int i = 0; i < s.Length - 1; i++)
            {
                int symbol = s[i];
                int nextSymbol = s[i + 1];

                sum += Math.Abs(symbol - nextSymbol);
            }
            
            Console.WriteLine(sum);
        }
    }
}
