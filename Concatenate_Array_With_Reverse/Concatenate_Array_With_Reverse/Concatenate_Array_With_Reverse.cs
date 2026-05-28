namespace Concatenate_Array_With_Reverse
{
    public class Concatenate_Array_With_Reverse
    {
        public Concatenate_Array_With_Reverse(int[] nums)
        {
            int[] result = new int[nums.Length * 2];

            for (int index = 0; index < nums.Length; index++)
            {
                result[index] = nums[index];
                result[index + nums.Length] = nums[(nums.Length - 1) - index];
            }

            foreach (int num in result) Console.Write(num + " ");
        }
    }
}
