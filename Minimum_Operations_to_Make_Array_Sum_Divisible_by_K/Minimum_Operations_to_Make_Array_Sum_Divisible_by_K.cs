namespace Minimum_Operations_to_Make_Array_Sum_Divisible_by_K
{
    public class Minimum_Operations_to_Make_Array_Sum_Divisible_by_K
    {
        private int sumNums = 0;
        public Minimum_Operations_to_Make_Array_Sum_Divisible_by_K(int[] nums, int k) 
        {
            foreach (int num in nums) sumNums += num;
            int result = sumNums % k;

            Console.WriteLine(result);
        }
    }
}
