/*  1470. Shuffle the Array

    Given the array nums consisting of 2n elements in the form [x1,x2,...,xn,y1,y2,...,yn].

    Return the array in the form [x1,y1,x2,y2,...,xn,yn].

    Example 1:

    Input: nums = [2,5,1,3,4,7], n = 3
    Output: [2,3,5,4,1,7] 
    Explanation: Since x1=2, x2=5, x3=1, y1=3, y2=4, y3=7 then the answer is [2,3,5,4,1,7].
    Example 2:

    Input: nums = [1,2,3,4,4,3,2,1], n = 4
    Output: [1,4,2,3,3,2,4,1]
    Example 3:

    Input: nums = [1,1,2,2], n = 2
    Output: [1,2,1,2]
 
    Constraints:

    1 <= n <= 500
    nums.length == 2n
    1 <= nums[i] <= 10^3
 */


namespace Shuffle_the_Array
{
    public class Program
    {
        private static int[] nums1 = { 2, 5, 1, 3, 4, 7 };
        private static int n1 = 3;

        private static int[] nums2 = { 1, 2, 3, 4, 4, 3, 2, 1 };
        private static int n2 = 4;

        private static int[] nums3 = { 1, 1, 2, 2 };
        private static int n3 = 2;
        private static void Main(string[] args)
        {
            Shuffle_the_Array shuffle_The_Array1 = new(nums1, n1);
            Shuffle_the_Array shuffle_The_Array2 = new(nums2, n2);
            Shuffle_the_Array shuffle_The_Array3 = new(nums3, n3);
        }
    }
}
