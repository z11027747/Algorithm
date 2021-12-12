using System.Collections.Generic;

namespace Algorithm
{
    public class __13CycleLinkNode
    {
        public class LinkListNode
        {
            public int value;
            public LinkListNode next;
        }

        public static bool HasCycle()
        {
            HashSet<LinkListNode> set = new HashSet<LinkListNode>();

            LinkListNode head = new LinkListNode();

            while (head != null)
            {
                if (!set.Add(head))
                    return true;

                head = head.next;
            }

            return false;
        }

        public static bool TwoPoint()
        {
            LinkListNode head = new LinkListNode();

            LinkListNode slow = head;
            LinkListNode quick = head.next;

            while (slow != quick)
            {
                if (quick == null || quick.next == null)
                    return false;

                slow = slow.next;
                quick = quick.next.next;
            }

            return true;
        }
    }
}