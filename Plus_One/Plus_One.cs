using System.Numerics;

namespace Plus_One
{
    public class Plus_One
    {
        private string stringIntegerNumber;
        private string stringNextIntegerNumber;

        private BigInteger integerNumber;
        private BigInteger nextIntegerNumber;

        private int[] arrResult;

        public Plus_One(int[] digits)
        {
            GetStringIntegerNumber(digits);
            GetIntegerNumber();
            GetNextIntegerNumber();
            GetStringNextIntegerNumber();
            CreateArrResult(digits);
            FillArrResult();
            ConsoleResult();
        }

        private void GetStringIntegerNumber(int[] digits)
        {
            foreach (int digit in digits) stringIntegerNumber += Convert.ToString(digit);
        }

        private void GetIntegerNumber() => integerNumber = BigInteger.Parse(stringIntegerNumber);

        private void GetNextIntegerNumber() => nextIntegerNumber = integerNumber + 1;

        private void GetStringNextIntegerNumber() => stringNextIntegerNumber = Convert.ToString(nextIntegerNumber);

        private void CreateArrResult(int[] digits)
        {
            if (stringIntegerNumber.Length == stringNextIntegerNumber.Length) arrResult = new int[digits.Length];
            else arrResult = new int[digits.Length + 1];
        }

        private void FillArrResult()
        {
            for (int index = 0; index < arrResult.Length; index++)
                arrResult[index] = int.Parse(stringNextIntegerNumber[index].ToString());
        }

        private void ConsoleResult()
        {
            foreach(int number in arrResult) Console.Write(number);
            Console.WriteLine();
        }
    }
}
