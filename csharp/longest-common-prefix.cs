/**
* https://leetcode.com/problems/longest-common-prefix/description/
*/
public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if (strs == null || strs.Length == 0) { return string.Empty; }
        if (strs.Length == 1) { return strs[0]; }

        Array.Sort(strs);
        StringBuilder result = new StringBuilder();
        string first = strs[0];
        string last = strs[strs.Length - 1];

        for (int i = 0; i < Math.Min(first.Length, last.Length); i++) {
            if (first[i] != last[i]) {
                return result.ToString();
            }
            result.Append(first[i]);
        }
        return result.ToString();
    }
}