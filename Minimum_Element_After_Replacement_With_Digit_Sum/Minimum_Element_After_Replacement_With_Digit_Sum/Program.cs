/*
3300. Minimum Element After Replacement With Digit Sum

You are given an integer array nums.

You replace each element in nums with the sum of its digits.

Return the minimum element in nums after all replacements.

Example 1:

Input: nums = [10,12,13,14]

Output: 1

Explanation:

nums becomes [1, 3, 4, 5] after all replacements, with minimum element 1.

Example 2:

Input: nums = [1,2,3,4]

Output: 1

Explanation:

nums becomes [1, 2, 3, 4] after all replacements, with minimum element 1.

Example 3:

Input: nums = [999,19,199]

Output: 10

Explanation:

nums becomes [27, 10, 19] after all replacements, with minimum element 10.

Constraints:

1 <= nums.length <= 100
1 <= nums[i] <= 104
*/

namespace Minimum_Element_After_Replacement_With_Digit_Sum
{
    public class Program
    {
        private static int[] nums1 = { 10, 12, 13, 14 };
        private static int[] nums2 = { 1, 2, 3, 4 };
        private static int[] nums3 = { 999, 19, 199 };

        public static void Main(string[] args)
        {
            Minimum_Element_After_Replacement_With_Digit_Sum minimum_Element_After_Replacement_With_Digit_Sum1 = new(nums1);
            Minimum_Element_After_Replacement_With_Digit_Sum minimum_Element_After_Replacement_With_Digit_Sum2 = new(nums2);
            Minimum_Element_After_Replacement_With_Digit_Sum minimum_Element_After_Replacement_With_Digit_Sum3 = new(nums3);
        }
    }
}
