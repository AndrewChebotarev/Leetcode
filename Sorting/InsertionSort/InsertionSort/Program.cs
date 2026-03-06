namespace InsertionSort
{
    public class Program
    {
        private static int[] testArray = { 6, 3, 8, 9, 2, 5 };
        public static void Main(string[] args)
        {
            InsertionSort insertionSort = new(testArray);
        }
    }
}
