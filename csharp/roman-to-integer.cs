/**
* https://leetcode.com/problems/roman-to-integer/description/
*/
public class Solution {
    public Dictionary<char, int> rn = new Dictionary<char, int>() {
        { 'I', 1 },
        { 'V', 5 },
        { 'X', 10 },
        { 'L', 50 },
        { 'C', 100 },
        { 'D', 500 },
        { 'M', 1000 },
    };

    public int RomanToInt(string s) {
        int total = 0;

        for (int i = 0; i < s.Length; i++) {
            // End of str handling
            if (i == s.Length - 1) {
                total += rn[s[i]];
                continue;
            }

            if (rn[s[i]] < rn[s[i + 1]]) {
                total -= rn[s[i]];
            } else {
                total += rn[s[i]];
            }
        }

        return total;    
    }
}

// iterate str from beginning
// if the i char is I, X, or C check:
// if the i + 1 char is either of the next 2 roman numerals in sequence
// if yes, subtract i value from i + 1 value, then move on to i + 2
// if no, add i value to total