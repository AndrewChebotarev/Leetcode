namespace BinarySearch
{
    public class Program
    {
        private static int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        public static void Main(string[] args)
        {
            BinarySearch binarySearch = new();

            int result = binarySearch.Searching(array, 3);
            Console.WriteLine("Результат обычного бинарного поиска = " + result);

            result = binarySearch.RecursiveSearching(array, 6, 0, array.Length - 1);
            Console.WriteLine("Результат рекурсивного бинарного поиска = " + result);
        }
    }
}
