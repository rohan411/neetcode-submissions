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
        List<int> results = new List<int>();
        foreach(var list in lists) {
            ListNode head = list;
            while(head != null) {
                results.Add(head.val);
                head = head.next;
            }
        }
        results.Sort();
        //Console.WriteLine($"{string.Join(", ",results)}");
        ListNode resultNode = new ListNode();
        ListNode dummy = resultNode;
        foreach(var result in results) {
            resultNode.next = new ListNode(result);
            resultNode = resultNode.next;
        }
        return dummy.next;
    }
}
