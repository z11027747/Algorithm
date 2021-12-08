namespace Algorithm
{
    public class _5ReverseLinkedList
    {
        public class LinkListNode
        {
            public int value;
            public LinkListNode next;
        }

        public static void Iterate()
        {
            LinkListNode head = new LinkListNode();

            LinkListNode prev = null;
            LinkListNode curr = head;

            while (curr != null)
            {
                LinkListNode next = curr.next;
                curr.next = prev;

                prev = curr;
                curr = next;
            }
        }

        public static LinkListNode Recursion(LinkListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }
            LinkListNode newHead = Recursion(head.next);
            head.next.next = head;
            head.next = null;
            return newHead;
        }
    }
}