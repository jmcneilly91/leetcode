/**
* https://leetcode.com/problems/palindrome-number/description/
*/
public class Solution {
    public bool IsPalindrome(int x) {
        string s = x.ToString();
        char[] chars = s.ToCharArray();

        // Default cases
        if (x < 0) return false;
        if (chars.Length == 1) return true;

        int j = chars.Length;
        for (int i = 0; i <= j; i++, j--) {
            if (chars[i] != chars[j]) {
                return false;   
            }
        }

        return true;
    }

    public bool IsPalindrome2(int x) {
        // Default cases
        if (x < 0) return false;

        int reversed = 0;
        int temp = x;

        while (temp > 0) {
            int digit = temp % 10;
            reversed = reversed * 10 + digit;
            temp = temp / 10;
        }

        return (reversed == x);
    }
}

// Defaults
// if len = 1, return true
// if len < 0, return false. Negative numbers can never be palindromes

// Method 1
// convert int to str
// convert str to char array
// iterate array with two poiners: left/front and back/end
// on each pass, check if chars are the same. If yes, isPalindrome remains true
// move towards the center of the array and stop when right <= left

// Method 2
// do not convert the int to a str
// reverse the int and then compare to the original. If equal, it is a palindrome