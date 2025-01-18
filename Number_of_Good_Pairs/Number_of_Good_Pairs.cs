namespace Number_of_Good_Pairs
{
    public class Number_of_Good_Pairs
    {
        public Number_of_Good_Pairs(int[] nums) 
        {
            int result = 0;

            for (int i = 0; i < nums.Length; i++)
                for (int j = i + 1; j < nums.Length; j++)
                    if (nums[i] == nums[j])
                        result++;
            
            Console.WriteLine(result);
        }
    }
}
