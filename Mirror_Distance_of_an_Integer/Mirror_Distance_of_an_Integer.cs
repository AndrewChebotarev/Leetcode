namespace Mirror_Distance_of_an_Integer
{
    public class Mirror_Distance_of_an_Integer
    {
        private int mirrorNumber = 0;
        private int resultCalculation = 0;

        public Mirror_Distance_of_an_Integer(int n) 
        {
            GetMirrorNumber(n);
            GetResultCalculation(n);

            Console.WriteLine(resultCalculation);
        }

        private void GetMirrorNumber(int n)
        {
            int tempNumber = n;

            while (tempNumber > 0)
            {
                int digit = tempNumber % 10;
                mirrorNumber = mirrorNumber * 10 + digit;
                tempNumber = tempNumber / 10;
            }
        }

        private void GetResultCalculation(int n) => resultCalculation = Math.Abs(n - mirrorNumber);
    }
}
