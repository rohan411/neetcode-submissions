public class Solution {
    public bool IsPalindrome(string s) {
        Stack<char> stack = new Stack<char>();
        foreach(char c in s) {
            bool isAsciiAlnum = (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') || (c >= '0' && c <= '9');
            if(!isAsciiAlnum) continue;
            stack.Push(char.ToLower(c));
        }
        s.Reverse();
        foreach(char c in s) {
            bool isAsciiAlnum = (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') || (c >= '0' && c <= '9');
            if(!isAsciiAlnum) continue;
            if(stack.Peek() == char.ToLower(c)) stack.Pop();
        }
        //Console.WriteLine($"stack {string.Join(", ", stack)}");
        return (stack.Count() == 0);
    }
}
