public class MinStack {
    private Stack<int> stack; 
    private Stack<int> min; 

    public MinStack() {
        stack = new Stack<int>();
        min = new Stack<int>();
    }
    
    public void Push(int val) {
       stack.Push(val);
       if(min.Count != 0) {
        int num = min.Peek();
        min.Push(Math.Min(num, val));
       } else {
        min.Push(val);
       }
    }
    
    public void Pop() {
        stack.Pop();
        min.Pop();
    }
    
    public int Top() {
       return stack.Peek();
    }
    
    public int GetMin() {
        return min.Peek();
    }
}
