public class Solution {
    public bool IsValidSudoku(char[][] board) {
        bool result = false;
        HashSet<int>[] rowCheckMap = new HashSet<int>[9];
        for(int i =0 ; i < 9; i++) {
        rowCheckMap[i] = new HashSet<int>(9);   
            for (int j =0 ; j < 9; j++ ) {
                if(board[i][j] == '.') continue; 
                if(rowCheckMap[i].Contains(board[i][j])) return result;
                rowCheckMap[i].Add(board[i][j]);
            }
        }
        HashSet<int>[] colCheckMap = new HashSet<int>[9];
        for(int k =0 ; k < 9; k++) {
        colCheckMap[k] = new HashSet<int>(9);   
            for (int l =0 ; l < 9; l++ ) {
                if(board[l][k] == '.') continue; 
                if(colCheckMap[k].Contains(board[l][k])) return result;
                colCheckMap[k].Add(board[l][k]);
            }
        }
        for(int m =0 ; m < 9; m++) {
        var subgridHash = new HashSet<int>(9);   
            for (int n =0 ; n < 3; n++ ) {
                for (int o = 0; o < 3; o++ ) {
                    int row = (m/3)*3 + n;
                    int col = (m%3)*3 + o;
                    if(board[row][col] == '.') continue;
                    if(subgridHash.Contains(board[row][col])) return result;
                    subgridHash.Add(board[row][col]);
                }
            }
        }
        result = true;
        return result;
    }
}
