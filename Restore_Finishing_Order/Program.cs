/*
3668. Restore Finishing Order

You are given an integer array order of length n and an integer array friends.

order contains every integer from 1 to n exactly once, representing the IDs of the participants of a race in their finishing order.
friends contains the IDs of your friends in the race sorted in strictly increasing order. Each ID in friends is guaranteed to appear in the order array.
Return an array containing your friends' IDs in their finishing order.

Example 1:

Input: order = [3,1,2,5,4], friends = [1,3,4]

Output: [3,1,4]

Explanation:

The finishing order is [3, 1, 2, 5, 4]. Therefore, the finishing order of your friends is [3, 1, 4].

Example 2:

Input: order = [1,4,5,3,2], friends = [2,5]

Output: [5,2]

Explanation:

The finishing order is [1, 4, 5, 3, 2]. Therefore, the finishing order of your friends is [5, 2].

Constraints:

1 <= n == order.length <= 100
order contains every integer from 1 to n exactly once
1 <= friends.length <= min(8, n)
1 <= friends[i] <= n
friends is strictly increasing
*/

namespace Restore_Finishing_Order
{
    public class Program
    {
        private static int[] order1 = { 3, 1, 2, 5, 4 };
        private static int[] friends1 = { 1, 3, 4 };

        private static int[] order2 = { 1, 4, 5, 3, 2 };
        private static int[] friends2 = { 2, 5 };

        public static void Main(string[] args)
        {
            Restore_Finishing_Order restore_Finishing_Order1 = new(order1, friends1);

            Console.WriteLine();

            Restore_Finishing_Order restore_Finishing_Order2 = new(order2, friends2);
        }
    }
}
