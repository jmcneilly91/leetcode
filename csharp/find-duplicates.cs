/*
Given an integer array nums of length n where all the integers of nums are in the range [1, n] and each integer appears once or twice, return an array of all the integers that appears twice.

You must write an algorithm that runs in O(n) time and uses only constant extra space.
*/

public class Solution {
    public IList<int> FindDuplicates(int[] nums) {
        Dictionary<int,int> hashMap = new Dictionary<int,int>();
        List<int> result = new List<int>();

        for (int i = 0; i < nums.Length; i++) {
            if (hashMap.ContainsKey(nums[i])) {
                result.Add(nums[i]);
            } else {
                hashMap.Add(nums[i], 0);
            }
        }

        return result;
    }
}