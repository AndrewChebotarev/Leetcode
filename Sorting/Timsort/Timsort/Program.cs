namespace Timsort
{
    public class Program
    {
        private static int[] array = { 64, 34, 25, 12, 22, 11, 90, 5, 77, 30, 2, 88, 45 };
        public static void Main(string[] args)
        {
            Timsort timsort = new(array);
        }
    }
}
