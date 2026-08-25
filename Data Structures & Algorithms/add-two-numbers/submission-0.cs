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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        // ListNode r1 = Reverse(l1);
        // ListNode r2 = Reverse(l2);
        ListNode dummy = new ListNode();
        ListNode result = dummy;
        int carry = 0;
        int sum = 0;
        while(l1 != null && l2 != null) {
            sum = l1.val + l2.val + carry;
            result.next = new ListNode(sum%10);
            carry = sum/10;
            l1 = l1.next;
            l2 = l2.next;
            result = result.next;
        }
        while(l1 != null) { 
            sum = l1.val + carry;
            result.next = new ListNode(sum%10);
            carry = sum/10;
            l1 = l1.next;
            result = result.next;
        }
        while(l2 != null) { 
            sum = l2.val + carry;
            result.next = new ListNode(sum%10);
            carry = sum/10;
            l2 = l2.next;
            result = result.next;
        }
        if(carry != 0) {
            result.next = new ListNode(carry);
            result = result.next;
        }
        return dummy.next;
    }

    private ListNode Reverse(ListNode head) {
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
