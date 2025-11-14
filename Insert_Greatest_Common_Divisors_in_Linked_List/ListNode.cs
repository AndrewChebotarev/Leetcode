//Definition for singly-linked list.

namespace Insert_Greatest_Common_Divisors_in_Linked_List
{
    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }

        public override string ToString()
        {
            List<string> values = new List<string>();
            ListNode current = this;

            while (current != null)
            {
                values.Add(current.val.ToString());
                current = current.next;
            }

            return string.Join(" -> ", values) + " -> null";
        }
    }
}
 