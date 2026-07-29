public class Solution {
    public bool IsPalindrome(string s) {
    int l = 0; int r = s.Length - 1;
        while(l < r){
        Console.WriteLine($"Chars {s[l]} , {s[r]}");
            while (l<r && !isAsciiAlnum(s[l])) l++;
            while (l<r && !isAsciiAlnum(s[r])) r--;
            Console.WriteLine($"After Chars {s[l]} , {s[r]}");
            if(char.ToLower(s[l]) != char.ToLower(s[r])) return false;
            l++; r--;
        }
        return true;
    }

    private bool isAsciiAlnum(char c){
        return (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') || (c >= '0' && c <= '9');
    } 
}
