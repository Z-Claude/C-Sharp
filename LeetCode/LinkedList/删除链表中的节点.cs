namespace LeetCode.LinkedList
{
    public static class 删除链表中的节点
    {
        public static void Main()
        {
            RemoveNthFromEnd(ListNode.Moc(), 2);
        }
        public static void DeleteNode(ListNode node)
        {
            node.val = node.next.val;
            node.next = node.next.next;
        }

        public static ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            var left = head;
            var right = head;
            for (int i = 0; i < n; i++)
            {
                right = right.next;
            }
            if (right == null)
            {
                return head.next;
            }
            while (right.next != null)
            {
                right = right.next;
                left = left.next;
            }
            left.next = left.next.next;
            return head;
        }
    }
}
