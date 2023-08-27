        if (string.IsNullOrEmpty(s)) return 0;
        
        int longestSubStr = 1;
        Dictionary<char, int> hashMap = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++) {
            if (!hashMap.ContainsKey(s[i])) {
                hashMap.Add(s[i], i);
            } else {
                if (hashMap.Count > longestSubStr) { longestSubStr = hashMap.Count; }
                hashMap.TryGetValue(s[i], out i);
                i++;
                hashMap.Clear();
                hashMap.Add(s[i], i);
            }
        }

        return hashMap.Count > longestSubStr ? hashMap.Count : longestSubStr;