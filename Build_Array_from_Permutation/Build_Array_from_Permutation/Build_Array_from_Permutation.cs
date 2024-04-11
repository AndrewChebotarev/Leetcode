namespace Build_Array_from_Permutation
{
    public class Build_Array_from_Permutation
    {
        public Build_Array_from_Permutation(int[] nums)
        {
            int[] ans = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
                ans[i] = nums[nums[i]];

            ViewResult(ans);

            Console.WriteLine();
        }

        void ViewResult(int[] ans)
        {
            foreach (int value in ans)
                Console.Write(value);
        }
    }
}
