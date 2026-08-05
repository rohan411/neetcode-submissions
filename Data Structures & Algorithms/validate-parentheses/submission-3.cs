public class Solution {
    public bool IsValid(string s) {
        int n = s.Length;
        if(n == 0 ) return false;
        Stack<char> stack = new Stack<char>();
        for(int i = 0; i < n; i++) {
            if(stack.Count > 0 && reqChar(stack.Peek()) == s[i]) {
                stack.Pop();
            } else {
                stack.Push(s[i]);
            }
        }
        return stack.Count == 0 ;
    }

    private char reqChar(char c) {
        switch(c) {
            case '(': return ')';
            case '{': return '}';
            case '[': return ']';
            default: return new char();
        }
    }
}
