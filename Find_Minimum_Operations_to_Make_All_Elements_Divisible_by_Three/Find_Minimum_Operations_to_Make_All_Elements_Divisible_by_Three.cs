namespace Find_Minimum_Operations_to_Make_All_Elements_Divisible_by_Three
{
    public class Find_Minimum_Operations_to_Make_All_Elements_Divisible_by_Three
    {
        private int operationCount = 0;
        public Find_Minimum_Operations_to_Make_All_Elements_Divisible_by_Three(int[] nums) 
        {
            foreach (int num in nums)
                if (num % 3 != 0)
                    operationCount++;
            

            Console.WriteLine(operationCount);
        }
    }
}
