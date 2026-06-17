namespace QuickSelect
{
    public class Program
    {
        private static int[] array = { 70, 20, 90, 10, 60, 30, 80, 50, 40 };
        public static void Main(string[] args)
        {
            QuickSelect quickSelect = new();
            int result = quickSelect.FindKthSmallest(array, 5);
            Console.WriteLine("Итеративный поиск: " + result);

            result = quickSelect.FindKthSmallestRecursive(array, 6);
            Console.WriteLine("Рекурсивный поиск: " + result);

            result = quickSelect.FindKthSmallestReadOnly(array, 4);
            Console.WriteLine("Поиск без изменения массива: " + result);
        }
    }
}
