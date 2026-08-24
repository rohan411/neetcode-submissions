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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        int count = 0;
        if(head == null || head.next == null) { return null; }
        ListNode temp = head, prev = null;
        while(temp != null) {
            count++;
            temp = temp.next;
        }
        int removeIndex = count - n;
        if (removeIndex == 0) return head.next;
        temp = head;
        while(removeIndex > 0) {
            prev = temp;
            temp = temp.next;
            removeIndex-- ;
        }
        prev.next = temp.next;
        return head;
    }
}
