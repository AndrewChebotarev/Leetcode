namespace Sqrt_x_
{
    public class Sqrt_x_
    {
        public Sqrt_x_(int x)
        {
            int result = 0;
            for (long num = 1; (num * num) <= x; num++) result = (int)num;

            Console.WriteLine(result);
        }
    }
}
