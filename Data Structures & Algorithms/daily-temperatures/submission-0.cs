public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        Stack<int> stack = new Stack<int>();
        int n = temperatures.Length;
        int[] result = new int[n];
        if(n == 0) return result;
        for(int i = 0; i < n; i++) {
            while(stack.Count > 0 && temperatures[i] > temperatures[stack.Peek()]) {
               int j = stack.Pop();
               result[j] = i - j;
                // Console.WriteLine($"temperature => {temperatures[i]}, count => {i - j}, stack => {string.Join(" ,", stack)}");
            }           
            stack.Push(i);
        }
        return result;
    }
}
