/*
    1512. Number of Good Pairs

    Given an array of integers nums, return the number of good pairs.

    A pair (i, j) is called good if nums[i] == nums[j] and i < j.

    Example 1:

    Input: nums = [1,2,3,1,1,3]
    Output: 4
    Explanation: There are 4 good pairs (0,3), (0,4), (3,4), (2,5) 0-indexed.
    Example 2:

    Input: nums = [1,1,1,1]
    Output: 6
    Explanation: Each pair in the array are good.
    Example 3:

    Input: nums = [1,2,3]
    Output: 0
 
    Constraints:

    1 <= nums.length <= 100
    1 <= nums[i] <= 100
 */

namespace Number_of_Good_Pairs
{
    public class Program
    {
        private static int[] nums1 = { 1, 2, 3, 1, 1, 3 };
        private static int[] nums2 = { 1, 1, 1, 1 };
        private static int[] nums3 = { 1, 2, 3 };

        static void Main(string[] args)
        {
            Number_of_Good_Pairs number_Of_Good_Pairs1 = new(nums1);
            Number_of_Good_Pairs number_Of_Good_Pairs2 = new(nums2);
            Number_of_Good_Pairs number_Of_Good_Pairs3 = new(nums3);
        }
    }
}
