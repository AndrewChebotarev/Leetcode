namespace Palindrome_Number
{
    public class Palindrome_Number
    {
        private char[]? xArray;
        private char[]? xReverseArray;

        public Palindrome_Number(int x) 
        {
            SetXArray(x);
            SetXReverseArray();
            CheckPalindrome();
        }

        private void SetXArray(int x) => xArray = Convert.ToString(x).ToCharArray();
        private void SetXReverseArray() => xReverseArray = xArray?.Reverse().ToArray();
        private void CheckPalindrome()
        {
            for (int index = 0; index < xArray?.Length; index++)
                if (xArray[index] != xReverseArray?[index])
                {
                    Console.WriteLine("false");
                    return;
                }

            Console.WriteLine("true");
        }
    }
}
