namespace Minimum_Element_After_Replacement_With_Digit_Sum
{
    public class Minimum_Element_After_Replacement_With_Digit_Sum
    {
        private string numString = "";
        private int numResult = 0;

        private int result = 0;

        public Minimum_Element_After_Replacement_With_Digit_Sum(int[] nums)
        {
            for (int index = 0; index < nums.Length; index++)
            {
                numString = GetNumString(nums, index);
                numResult = GetNumResult(numString);

                SetFirstIndex(index);
                CheckMinResult();
            }

            Console.WriteLine(result);
        }

        private string GetNumString(int[] nums, int index) => nums[index].ToString();

        private int GetNumResult(string numString)
        {
            int numResult = 0;
            foreach (char symbol in numString) numResult += int.Parse(symbol.ToString());

            return numResult;
        }

        private void SetFirstIndex(int index)
        {
            if (index == 0) result = numResult;
        }

        private void CheckMinResult()
        {
            if (result > numResult) result = numResult;
        }
    }
}
