namespace Majority_Element
{
    public class Majority_Element
    {
        private int numberCount = 0;
        public Majority_Element(int[] nums) 
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j]) numberCount++;
                    if (numberCount > nums.Length / 2)
                    {
                        Console.WriteLine(nums[i]);
                        return;
                    }
                }
                numberCount = 0;
            }
            Console.WriteLine("Error");
        }
    }
}
