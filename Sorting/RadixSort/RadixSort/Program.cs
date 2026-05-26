namespace RadixSort
{
    public class Program
    {
        private static int[] array = { 170, 45, 75, 90, 802, 24, 2, 66 };
        public static void Main(string[] args)
        {
            RadixSort radixSort = new(array);
        }
    }
}
