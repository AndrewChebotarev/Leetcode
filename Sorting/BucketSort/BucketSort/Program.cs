namespace BucketSort
{
    public class Program
    {
        private static int[] array = { 42, 17, 89, 3, 56, 91, 23, 8, 67, 34, 78, 12 };
        public static void Main(string[] args)
        {
            BucketSort bucketSort = new(array);
        }
    }
}
