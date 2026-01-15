namespace Compute_Alternating_Sum
{
    public class Compute_Alternating_Sum
    {
        private int result = 0;

        public Compute_Alternating_Sum(int[] nums) 
        {
            for (int index = 0; index < nums.Length; index++)
            {
                int remainderDivision = index % 2;

                if (remainderDivision == 0) result += nums[index];
                else result -= nums[index];
            }

            Console.WriteLine(result);
        }
    }
}
