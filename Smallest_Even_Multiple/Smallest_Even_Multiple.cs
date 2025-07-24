namespace Smallest_Even_Multiple
{
    public class Smallest_Even_Multiple
    {
        public Smallest_Even_Multiple(int n) 
        {
            if (CheckMultipleItSelf(n)) Console.WriteLine(n);
            else Console.WriteLine(GetSmallestMultiple(n));
        }

        private bool CheckMultipleItSelf(int n) => n % 2 == 0;

        private int GetSmallestMultiple(int n) => n * 2;
    }
}
