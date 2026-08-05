public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> stack = new Stack<int>();
        int result = 0;
        for(int i=0; i< tokens.Length; i++) {   
            string s = tokens[i];
            switch(s) {
                case "+": {
                    int b = stack.Pop();
                    int a = stack.Pop();
                    stack.Push(a+b);
                    break;
                }      
                case "-": {
                    int b = stack.Pop();
                    int a = stack.Pop();
                    stack.Push(a-b);
                    break;
                }
                case "*": {
                    int b = stack.Pop();
                    int a = stack.Pop();
                    stack.Push(a*b);
                    break;
                }      
                case "/": {
                    int b = stack.Pop();
                    int a = stack.Pop();
                    stack.Push(a/b);
                    break;
                }
                default:
                stack.Push(int.Parse(s));
                break;
            }
        }
        return stack.Peek();
    }
}
