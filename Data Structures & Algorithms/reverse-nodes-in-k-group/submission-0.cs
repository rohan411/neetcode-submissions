/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution {
    public ListNode ReverseKGroup(ListNode head, int k) {
        var dummy = new ListNode(0, head);
        ListNode prevGroupTail = dummy;

        while (true)
        {
            // Find the k-th node of this group
            ListNode kth = prevGroupTail;
            for (int i = 0; i < k; i++)
            {
                kth = kth.next;
                if (kth == null)
                    return dummy.next; // fewer than k nodes left
            }

            ListNode nextGroupHead = kth.next;

            // Reverse the group; start prev at nextGroupHead so the new tail links forward
            ListNode prev = nextGroupHead;
            ListNode curr = prevGroupTail.next;
            while (curr != nextGroupHead)
            {
                ListNode nxt = curr.next;
                curr.next = prev;
                prev = curr;
                curr = nxt;
            }

            // Reconnect and advance
            ListNode oldFirst = prevGroupTail.next; // becomes this group's tail
            prevGroupTail.next = kth;               // kth is the group's new head
            prevGroupTail = oldFirst;
        }
    }

    private ListNode ReverseNode(ListNode head, int k) {
        if(head == null) return null;
        ListNode prev = null, next = head;
        while(k > 0) {
            next = head.next;
            head.next = prev;
            prev = head;
            head = next;
        }
        return prev;
    }
}
