/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node copyRandomList(Node head) {
        Dictionary<Node, Node> dt = new Dictionary<Node, Node>();
        Node dummy = new Node(0);
        Node temp = dummy;
        Node curr = head;
        while(curr != null) {
            temp.next = new Node(curr.val);
            temp = temp.next;
            dt[curr] = temp;
            curr = curr.next;
        }
        temp = dummy.next;
        curr = head;
        while(curr != null) {
            if(curr.random != null) {
                temp.random = dt[curr.random];
            }
            temp = temp.next;
            curr = curr.next;
        }
        return dummy.next;
    }
}
