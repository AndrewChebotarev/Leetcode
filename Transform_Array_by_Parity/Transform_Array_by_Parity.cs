namespace Transform_Array_by_Parity
{
    public class Transform_Array_by_Parity
    {
        private int evenNumber = 0;
        private int oddNumber = 1;
        public Transform_Array_by_Parity(int[] nums) 
        {
            for (int index = 0; index < nums.Length; index++)
            {
                if (CheckNumber(nums[index]))
                    nums[index] = evenNumber;
                else
                    nums[index] = oddNumber;
            }

            Array.Sort(nums);
            SetResultConsole(nums);
        }

        private bool CheckNumber(int number)
        {
            if (number % 2 == 0)
                return true;
            else
                return false;
        }

        private void SetResultConsole(int[] resultNums)
        {
            foreach (int num in resultNums)
                Console.Write(num.ToString() + " ");

            Console.WriteLine();
        }
    }
}
