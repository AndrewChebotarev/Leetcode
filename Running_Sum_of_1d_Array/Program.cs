/*
1480. Running Sum of 1d Array

Given an array nums. We define a running sum of an array as runningSum[i] = sum(nums[0]…nums[i]).

Return the running sum of nums.

Example 1:

Input: nums = [1,2,3,4]
Output: [1,3,6,10]
Explanation: Running sum is obtained as follows: [1, 1+2, 1+2+3, 1+2+3+4].

Example 2:

Input: nums = [1,1,1,1,1]
Output: [1,2,3,4,5]
Explanation: Running sum is obtained as follows: [1, 1+1, 1+1+1, 1+1+1+1, 1+1+1+1+1].

Example 3:

Input: nums = [3,1,2,10,1]
Output: [3,4,6,16,17]

Constraints:

1 <= nums.length <= 1000
-10^6 <= nums[i] <= 10^6
*/
namespace Running_Sum_of_1d_Array
{
    public class Program
    {
        private static int[] nums1 = { 1, 2, 3, 4 };
        private static int[] nums2 = { 1, 1, 1, 1, 1 };
        private static int[] nums3 = { 3, 1, 2, 10, 1 };

        public static void Main(string[] args)
        {
            Running_Sum_of_1d_Array running_Sum_Of_1D_Array1 = new(nums1);
            Console.WriteLine();
            Running_Sum_of_1d_Array running_Sum_Of_1D_Array2 = new(nums2);
            Console.WriteLine();
            Running_Sum_of_1d_Array running_Sum_Of_1D_Array3 = new(nums3);
        }
    }
}
