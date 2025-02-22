namespace Divisible_and_Non_divisible_Sums_Difference
{
    public class Divisible_and_Non_divisible_Sums_Difference
    {
        private int num1 = 0;
        private int num2 = 0;
        public Divisible_and_Non_divisible_Sums_Difference(int n, int m) 
        {
            for (int i = 0; i <= n; i++)
            {
                if (i % m != 0)
                    num1 += i;
                else
                    num2 += i;
            }

            int result = num1 - num2;

            Console.WriteLine(result);
        }
    }
}
