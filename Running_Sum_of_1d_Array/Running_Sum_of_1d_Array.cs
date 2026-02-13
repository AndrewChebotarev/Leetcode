namespace Running_Sum_of_1d_Array
{
    public class Running_Sum_of_1d_Array
    {
        private int tempSum = 0;
        private int[] resultArray;

        public Running_Sum_of_1d_Array(int[] nums)
        {
            InitResultArray(nums);
            FillResultArray(nums);

            foreach (int num in resultArray) Console.Write(num + " ");
        }

        private void InitResultArray(int[] nums) => resultArray = new int[nums.Length];

        private void FillResultArray(int[] nums)
        {
            for (int index = 0; index < nums.Length; index++)
            {
                tempSum += nums[index];
                resultArray[index] = tempSum;
            }
        }
    }
}
