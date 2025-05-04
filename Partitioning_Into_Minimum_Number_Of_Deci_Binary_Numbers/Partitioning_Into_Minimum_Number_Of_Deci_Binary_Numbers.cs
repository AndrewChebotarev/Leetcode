namespace Partitioning_Into_Minimum_Number_Of_Deci_Binary_Numbers
{
    public class Partitioning_Into_Minimum_Number_Of_Deci_Binary_Numbers
    {
        private int maxSymbol;

        public Partitioning_Into_Minimum_Number_Of_Deci_Binary_Numbers(string number)
        {
            foreach (char symbol in number)
            {
                int currentDigit = symbol - '0';

                if (maxSymbol < currentDigit)
                    maxSymbol = currentDigit;
            }

            Console.WriteLine(maxSymbol);
        }
    }
}
