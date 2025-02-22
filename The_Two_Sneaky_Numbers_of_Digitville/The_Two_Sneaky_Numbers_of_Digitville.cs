namespace The_Two_Sneaky_Numbers_of_Digitville
{
    public class The_Two_Sneaky_Numbers_of_Digitville
    {
        private bool checkFirstNum = false;
        private int[] twoNums = new int[2];
        public The_Two_Sneaky_Numbers_of_Digitville(int[] nums)
        {
            CheckNums(nums);
            ConsoleWriteData();
        }

        private void CheckNums(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
                ComparisonNumbers(nums, i);
        }

        private void ComparisonNumbers(int[] nums, int i)
        {
            for (int j = i + 1; j < nums.Length; j++)
                EqualityTest(nums, i, j);
        }

        private void EqualityTest(int[] nums, int i, int j)
        {
            if (nums[i] == nums[j])
            {
                FindFirstNum(nums, j);
                FindSecondNum(nums, j);
            }
        }

        private void FindFirstNum(int[] nums, int j)
        {
            if (!checkFirstNum)
            {
                twoNums[0] = nums[j];
                checkFirstNum = true;
            }
        }

        private void FindSecondNum(int[] nums, int j)
        {
            if (checkFirstNum)
                twoNums[1] = nums[j];
        }

        private void ConsoleWriteData()
        {
            foreach(int num in twoNums)
                Console.Write(num.ToString() + " ");

            Console.WriteLine();
        }
    }
}
