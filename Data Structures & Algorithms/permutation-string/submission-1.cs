public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        bool result = false;
        int n = s1.Length;
        int m = s2.Length;
        int[] arr = new int[26];
        foreach(char c in s1) {
            arr[c - 'a']++;
        }
        for(int i = 0; i < m; i++) {
            var tempArr = arr.ToArray();
            for( int j = 0; j< n &&  j + i < m; j++) {
                tempArr[s2[i+j] - 'a']--;
                //Console.WriteLine($" i => {i},  j => {j}, tempArr[s2[i+j] => {tempArr[s2[i+j] - 'a']}");
            }
            bool localResult = true;
            foreach(int count in tempArr) {
                if(count != 0 ) localResult  = false;
            }
            result = result || localResult;
        }
        return result;
    }
}
