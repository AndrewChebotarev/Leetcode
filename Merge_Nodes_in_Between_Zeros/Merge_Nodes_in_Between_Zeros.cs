namespace Merge_Nodes_in_Between_Zeros
{
    public class Merge_Nodes_in_Between_Zeros
    {
        private ListNode dummy = new ListNode();
        private int sum = 0;

        public Merge_Nodes_in_Between_Zeros(ListNode head)
        {
            ListNode current = dummy;
            ListNode runner = head.next;

            while (runner != null)
            {
                if (runner.val != 0)
                    sum += runner.val;
                else
                {
                    current.next = new ListNode(sum);
                    current = current.next;
                    sum = 0;
                }

                runner = runner.next;
            }

            PrintList(dummy.next);
        }

        public void PrintList(ListNode head)
        {
            ListNode current = head;

            while (current != null)
            {
                Console.Write(current.val);

                if (current.next != null)
                    Console.Write(" ");

                current = current.next;
            }

            Console.WriteLine();
        }
    }
}
