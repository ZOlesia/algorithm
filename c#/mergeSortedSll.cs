namespace c_
{
    public class mergeSortedSll
    {
        public class ListNode {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
            var sll = new ListNode(-1);

            var head1 = l1;
            var head2 = l2;
            
            var runner = sll;

            while(head1 != null && head2 != null)
            {
                if(head1.val <= head2.val)
                {
                    runner.next = head1;
                    head1 = head1.next;
                } 
                else
                {
                    runner.next = head2;
                    head2 = head2.next;
                }
                runner = runner.next;
            }

            if(l1 == null)
            {
                runner.next = head2;

            }
            else
            {
                runner.next = head1;
            }

            var newSll = sll.next;
            sll.next = null;

            return newSll;
        }
    }
}