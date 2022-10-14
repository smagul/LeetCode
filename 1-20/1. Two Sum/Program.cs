// https://leetcode.com/problems/two-sum/
// Difficulty - #Easy
// Topics - #Array, #Hash_Table

int target = 9;
int[] nums = new int[] { 2, 7, 11, 15 };
int[] sums = TwoSum(nums, target);
foreach (int sum in sums)
{
    Console.WriteLine(sum); // 0, 1
}

// Time complexity  : O(n)
// Space complexity : O(n)
int[] TwoSum(int[] nums, int target)
{
    Dictionary<int, int> dict = new();
    for (int i = 0; i < nums.Length; i++)
    {
        int diff = target - nums[i];
        if (dict.ContainsKey(diff))
        {
            return new int[] { dict[diff], i };
        }

        if (!dict.ContainsKey(nums[i]))
        {
            dict.Add(nums[i], i);
        }
    }

    return new int[] { };
}