// https://leetcode.com/problems/longest-substring-without-repeating-characters/
// Difficulty - #Medium
// Topics - #Hash_Table, #String, #Sliding_Window

string s = "abcabcbb";

int lengthOfLongestSubstring = LengthOfLongestSubstring(s);
Console.WriteLine(lengthOfLongestSubstring); // 3

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