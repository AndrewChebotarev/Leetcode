namespace Minimum_Bit_Flips_to_Convert_Number
{
    public class Minimum_Bit_Flips_to_Convert_Number
    {
        private string startString = "";
        private string goalString = "";

        private int result = 0;

        public Minimum_Bit_Flips_to_Convert_Number(int start, int goal)
        {
            ConvertIntToString(start, goal);
            SetMaxLength();
            CalculationResult();

            Console.WriteLine(result.ToString());
        }

        private void ConvertIntToString(int start, int goal)
        {
            startString = Convert.ToString(start, 2);
            goalString = Convert.ToString(goal, 2);
        }

        private void SetMaxLength()
        {
            int maxLength = Math.Max(startString.Length, goalString.Length);

            startString = startString.PadLeft(maxLength, '0');
            goalString = goalString.PadLeft(maxLength, '0');
        }

        private void CalculationResult()
        {
            for (int index = 0; index < startString.Length; index++)
                if (startString[index] != goalString[index])
                    result++;
        }
    }
}
