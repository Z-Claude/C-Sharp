namespace LeetCode.LinkedList
{
    public static class 反转链表
    {
        public static void Main(string[] ages)
        {
            ReverseList1(ListNode.Moc());
        }
        public static ListNode ReverseList(ListNode head)
        {
            //先进后出特性
            var node = head;
            var nodes = new Stack<ListNode>();
            while (node != null)
            {
                nodes.Push(node);
                node = node.next;
            }
            if (!nodes.Any())
            {
                return null;
            }
            var top = nodes.Pop();
            var dummy = top;
            while (nodes.Count > 0)
            {
                var list = nodes.Pop();
                top.next = list;
                top = top.next;
            }
            top.next = null;
            return dummy;
        }
        public static ListNode ReverseList1(ListNode head)
        {
            //每次都是新的head
            ListNode show = null;
            while (head != null)
            {
                var list = new ListNode(head.val);
                list.next = show;
                show = list;
                head = head.next;
            }

            return show;
        }
    }
}
