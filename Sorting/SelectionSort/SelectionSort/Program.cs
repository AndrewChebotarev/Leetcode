namespace SelectionSort
{
    public class Program
    {
        private static int[] testArray = { 5, 2, 9, 1, 5, 6 };
        public static void Main(string[] args)
        {
            SelectionSort selectionSort = new(testArray);
        }
    }
}
