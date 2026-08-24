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
    public void ReorderList(ListNode head) {
        if (head == null || head.next == null) return;
        ListNode temp = head, slow = head, fast = head;
        while(fast != null && fast.next != null) {
            temp = slow;
            slow = slow.next;
            fast = fast.next.next;
        }
        ListNode reverse = ReverseList(slow);
        temp.next = null;
        ListNode dummy = new ListNode();
        ListNode result = dummy;
        while(head != null || reverse != null) {
            if(head != null) {result.next = head; head = head.next; result = result.next; }
            if(reverse != null) {result.next = reverse; reverse = reverse.next; result = result.next; }
        }
        head = dummy.next;
    }

    private ListNode ReverseList(ListNode head) {
        ListNode prev = null, next = head;
        while(head != null) {
            next = head.next;
            head.next = prev;
            prev = head;
            head = next; 
        }
        return prev;
    }
}
