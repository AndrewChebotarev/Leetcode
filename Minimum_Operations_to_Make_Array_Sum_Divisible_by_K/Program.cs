/*
3512. Minimum Operations to Make Array Sum Divisible by K

You are given an integer array nums and an integer k. You can perform the following operation any number of times:

Select an index i and replace nums[i] with nums[i] - 1.
Return the minimum number of operations required to make the sum of the array divisible by k.

Example 1:

Input: nums = [3,9,7], k = 5

Output: 4

Explanation:

Perform 4 operations on nums[1] = 9. Now, nums = [3, 5, 7].
The sum is 15, which is divisible by 5.

Example 2:

Input: nums = [4,1,3], k = 4

Output: 0

Explanation:

The sum is 8, which is already divisible by 4. Hence, no operations are needed.

Example 3:

Input: nums = [3,2], k = 6

Output: 5

Explanation:

Perform 3 operations on nums[0] = 3 and 2 operations on nums[1] = 2. Now, nums = [0, 0].
The sum is 0, which is divisible by 6.
 
Constraints:

1 <= nums.length <= 1000
1 <= nums[i] <= 1000
1 <= k <= 100
*/

namespace Minimum_Operations_to_Make_Array_Sum_Divisible_by_K
{
    public class Program
    {
        private static int[] nums1 = { 3, 9, 7 };
        private static int[] nums2 = { 4, 1, 3 };
        private static int[] nums3 = { 3, 2 };

        private static int k1 = 5;
        private static int k2 = 4;
        private static int k3 = 6;

        public static void Main(string[] args)
        {
            Minimum_Operations_to_Make_Array_Sum_Divisible_by_K minimum_Operations_To_Make_Array_Sum_Divisible_By_K1 = new(nums1, k1);
            Minimum_Operations_to_Make_Array_Sum_Divisible_by_K minimum_Operations_To_Make_Array_Sum_Divisible_By_K2 = new(nums2, k2);
            Minimum_Operations_to_Make_Array_Sum_Divisible_by_K minimum_Operations_To_Make_Array_Sum_Divisible_By_K3 = new(nums3, k3);
        }
    }
}
