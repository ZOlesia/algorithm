namespace leetcode
{
    public class ReverseSLL
    {
        public class ListNode {
             public int val;
             public ListNode next;
             public ListNode(int x) { val = x; }
         }

        public static ListNode ReverseList(ListNode head) {

            var r = head;
            ListNode p = null;
            
            while(r != null){
                ListNode h = r.next;
                r.next = p;
                p = r;
                r = h;
                
            }
            

            
            head = p;
            
            
            return head;
        }
    }
}