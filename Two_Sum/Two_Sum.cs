namespace Two_Sum
{
    public class Two_Sum
    {
        public Two_Sum(int[] nums, int target)
        {
            int[] result = GetTwoSum(nums, target);
            Console.WriteLine($"[{result[0]},{result[1]}]");
        }

        private int[] GetTwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
                for (int j = 0; j < nums.Length; j++)
                    if (nums[i] + nums[j] == target && i != j)
                        return new int[] { i, j };

            throw new ArgumentException("Error!");
        }
    }
}
