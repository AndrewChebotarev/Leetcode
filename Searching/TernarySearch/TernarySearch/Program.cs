namespace TernarySearch
{
    public class Program
    {
        public static void Main(string[] args)
        {
            TernarySearch ternarySearch = new TernarySearch();

            double result = ternarySearch.FindMinimum(FunctionForMin, -100, 100);
            Console.WriteLine("Тернарынй оператор (обычный минимум) = " + result);

            result = ternarySearch.FindMaximum(FunctionForMax, -100, 100);
            Console.WriteLine("Тернарынй оператор (обычный максимум) = " + result);

            result = ternarySearch.FindMinimumRecursive(FunctionForMin, -100, 100);
            Console.WriteLine("Тернарынй оператор (рекурсивный минимум) = " + result);

            result = ternarySearch.FindManimumRecursive(FunctionForMax, -100, 100);
            Console.WriteLine("Тернарынй оператор (рекурсивный максимум) = " + result);
        }

        private static double FunctionForMin(double x)
        {
            return (x - 2) * (x - 2) + 1;
        }

        private static double FunctionForMax(double x)
        {
            return -(x - 2) * (x - 2) + 10;
        }
    }
}
