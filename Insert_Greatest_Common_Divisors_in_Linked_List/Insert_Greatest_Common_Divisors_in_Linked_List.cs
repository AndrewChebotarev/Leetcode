namespace Insert_Greatest_Common_Divisors_in_Linked_List
{
    public class Insert_Greatest_Common_Divisors_in_Linked_List
    {
        public Insert_Greatest_Common_Divisors_in_Linked_List(ListNode head)
        {
            if (!CheckNullHead(head))
            {
                Console.WriteLine(head.ToString());
                return;
            }

            if (!CheckSingleHead(head))
            {
                Console.WriteLine(head.ToString());
                return;
            }

            ListNode current = head;

            while (current != null && current.next != null)
            {
                int gcdValue = GCD(current.val, current.next.val);

                ListNode newNode = new(gcdValue);

                newNode.next = current.next;
                current.next = newNode;

                current = newNode.next;
            }

            Console.WriteLine(head.ToString());
        }

        private bool CheckNullHead(ListNode head)
        {
            if (head == null) return false;
            else return true;
        }

        private bool CheckSingleHead(ListNode head)
        {
            if (head.next == null) return false;
            else return true;
        }

        private int GCD(int firstValue, int secondValue)
        {
            while (secondValue != 0)
            {
                int temp = secondValue;
                secondValue = firstValue % secondValue;
                firstValue = temp;
            }

            return firstValue;
        }
    }
}
