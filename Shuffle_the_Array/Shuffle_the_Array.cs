namespace Shuffle_the_Array
{
    public class Shuffle_the_Array
    {
        public Shuffle_the_Array(int[] nums, int n) 
        {
            int[] result = new int[nums.Length];

            for (int i = 0, j = 0; i < nums.Length - n; i++, j += 2)
                result[j] = nums[i];

            for (int i = n, j = 1; i < nums.Length; i++, j += 2)
                result[j] = nums[i];

            foreach (int res in result)
                Console.Write(res + " ");

            Console.WriteLine();
        }
    }
}
