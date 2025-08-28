using System.Numerics;

namespace Sum_mof_Values_at_Indices_With_K_Set_Bits
{
    public class Sum_mof_Values_at_Indices_With_K_Set_Bits
    {
        private int result = 0;

        public Sum_mof_Values_at_Indices_With_K_Set_Bits(IList<int> nums, int k)
        {
            for (int i = 0; i < nums.Count; i++)
                if (BitOperations.PopCount((uint)i) == k)
                    result += nums[i];

            Console.WriteLine(result);
        }
    }
}
