public class LRUCache {
    private class Node {
        public int key;
        public int val;
        public Node prev;
        public Node next;

        public Node(int key = 0, int val = 0, Node prev = null, Node next = null) {
            this.key = key;
            this.val = val;
            this.prev = prev;
            this.next = next;
        }
    }
    private int capacity;
    private Dictionary<int, Node> map = new Dictionary<int, Node>();
    private Node head; // dummy — head.next is the LRU (least recently used) node
    private Node tail; // dummy — tail.prev is the MRU (most recently used) node

    public LRUCache(int capacity) {
        this.capacity = capacity;
        head = new Node();
        tail = new Node();
        head.next = tail;
        tail.prev = head;
    }
    
    public int Get(int key) {
        if(map.TryGetValue(key, out Node node)) {
           Remove(node);
           InsertAtTail(node);
           return node.val;
        }
        
        return -1;
    }
    
    public void Put(int key, int value) {
        if (map.TryGetValue(key, out Node existing)) {
            existing.val = value;
            Remove(existing);
            InsertAtTail(existing);
            return;
        }
        if (map.Count == capacity) {
            Node lru = head.next;      // least-recently-used = right after the dummy head
            Remove(lru);
            map.Remove(lru.key);
        }
        
        Node node = new Node(key, value);
        map[key] = node;
        InsertAtTail(node);
    }

    private void Remove(Node node) {
        Node p = node.prev;
        Node n = node.next;
        p.next = n;
        n.prev = p;
    }

    private void InsertAtTail(Node node) {
        Node p = tail.prev;
        p.next = node;
        node.prev = p;
        node.next = tail;
        tail.prev = node;
    }
}