namespace Shuffle_the_Array
{
    public class Shuffle_the_Array
    {
        private int[] result;

        public int[] Shuffle(int[] nums, int n)
        {
            result = new int[nums.Length];

            SetX(nums);
            SetY(nums, n);

            return result;
        }

        private void SetX(int[] nums)
        {
            for (int i = 0, j = 0; i < nums.Length; i += 2, j++) result[i] = nums[j];
        }

        private void SetY(int[] nums, int n)
        {
            for (int i = 1, j = n; i < nums.Length; i += 2, j++) result[i] = nums[j];
        }
    }
}
