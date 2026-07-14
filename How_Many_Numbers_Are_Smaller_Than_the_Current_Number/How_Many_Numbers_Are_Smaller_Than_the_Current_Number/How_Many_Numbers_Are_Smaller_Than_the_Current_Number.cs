using System;
using System.Collections.Generic;
using System.Text;

namespace How_Many_Numbers_Are_Smaller_Than_the_Current_Number
{
    public class How_Many_Numbers_Are_Smaller_Than_the_Current_Number
    {
        private int counter;
        private int[] result;

        public int[] SmallerNumbersThanCurrent(int[] nums)
        {
            InitResultArray(nums);
            SearchManyNumbers(nums);

            return result;
        }

        private void InitResultArray(int[] nums) => result = new int[nums.Length];

        private void SearchManyNumbers(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                counter = 0;

                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j]) counter++;
                    if (nums.Length - 1 == j) result[i] = counter;
                }
            }
        }
    }
}
