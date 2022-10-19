// https://leetcode.com/problems/longest-substring-without-repeating-characters/
// Difficulty - #Medium
// Topics - #Hash_Table, #String, #Sliding_Window

string s = "abcabcbb";
int lengthOfLongestSubstring = LengthOfLongestSubstring(s);
Console.WriteLine(lengthOfLongestSubstring); // 3

// Time complexity  : O(n)
// Space complexity : O(n)
/*
int LengthOfLongestSubstring(string s)
{
    HashSet<char> hs = new();
    int l = 0;
    int result = 0;
    for (int r = 0; r < s.Length; r++)
    {
        while (hs.Contains(s[r]))
        {
            hs.Remove(s[l]);
            l++;
        }
        hs.Add(s[r]);
        result = Math.Max(result, r - l + 1);
    }

    return result;
}
*/

// Time complexity  : O(n)
// Space complexity : O(128) = O(1)
int LengthOfLongestSubstring(string s)
{
    int[] count = new int[128];
    int ans = 0, l = 0;

    for (int r = 0; r < s.Length; r++)
    {
        count[s[r]]++;
        while (count[s[r]] > 1)
        {
            --count[s[l++]];
        }
        ans = Math.Max(ans, r - l + 1);
    }

    return ans;
}