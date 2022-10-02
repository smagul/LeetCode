// https://leetcode.com/problems/permutation-in-string/
// Difficulty - #Medium
// Topics - #Hash_Table, #Two_Pointers, #String, #Sliding_Window

string s1 = "ab", s2 = "eidbaooo";
bool included = CheckInclusion(s1, s2);
Console.WriteLine(included); // true

// Time complexity  : O(n)
// Space complexity : O(1)
bool CheckInclusion(string s1, string s2)
{
    if (s1.Length > s2.Length)
    {
        return false;
    }

    int[] arr = new int[26];
    for (int k = 0; k < s1.Length; k++)
    {
        arr[s1[k] - 'a']++;
        arr[s2[k] - 'a']--;
    }

    if (IsEmpty(arr))
    {
        return true;
    }

    int i = 0, j = s1.Length;
    while (j < s2.Length)
    {
        if (IsEmpty(arr))
        {
            return true;
        }
        arr[s2[i++] - 'a']++;
        arr[s2[j++] - 'a']--;
    }

    return false;
}

bool IsEmpty(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] != 0)
        {
            return false;
        }
    }

    return true;
}