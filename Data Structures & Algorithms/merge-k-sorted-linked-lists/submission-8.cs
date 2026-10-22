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
    public ListNode MergeKLists(ListNode[] lists) {
        if (lists.Length == 0) return null;
        for(int step = 1; step < lists.Length; step *=2 ) {
            for(int i = 0; i+step < lists.Length; i += 2*step) {
                lists[i] = mergeTwoLists(lists[i], lists[i+step]);
            }
        }
        return lists[0];
    }

    private ListNode mergeTwoLists(ListNode node1, ListNode node2) {
        ListNode result = new ListNode();
        ListNode dummy = result;
        while( node1!= null && node2 != null) {
            if(node1.val <= node2.val) {
                result.next = node1;
                node1 = node1.next;
            } else {
                result.next = node2;
                node2 = node2.next;
            }
            result = result.next;
        }
        result.next = node1 ?? node2;
        return dummy.next;
    }
}

