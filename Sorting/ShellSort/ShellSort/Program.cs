namespace ShellSort
{
    public class Program
    {
        private static int[] testArray = { 5, 2, 8, 1, 9, 3 };
        
        public static void Main(string[] args)
        {
            ShellSort shellSort = new(testArray);
        }
    }
}
