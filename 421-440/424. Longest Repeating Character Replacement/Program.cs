// https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
// Difficulty - #Medium
// Topics - #Hash_Table, #String, #Sliding_Window

string s = "AABABBA";
int k = 1;
int longestRepeatingLetters = CharacterReplacement(s, k);
Console.WriteLine(longestRepeatingLetters); // 4

// Time complexity  : O(n)
// Space complexity : O(1)
int CharacterReplacement(string s, int k)
{
    int[] arr = new int[26];
    int i = 0;
    int res = 0;
    int max = 0;

    for (int j = 0; j < s.Length; j++)
    {
        max = Math.Max(max, ++arr[s[j] - 'A']);
        if (j - i + 1 - max > k)
        {
            arr[s[i] - 'A']--;
            i++;
        }
        res = Math.Max(res, j - i + 1);
    }

    return res;
}
