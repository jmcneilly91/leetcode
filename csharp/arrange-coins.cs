public class Solution {
    public int ArrangeCoins(int n) {
        int row = 0; // # rows
        int sum = 1;

        while (n - sum >= 0) {
            row++;
            n = n - sum;
            sum++;
        } 

        return row;
    }
}