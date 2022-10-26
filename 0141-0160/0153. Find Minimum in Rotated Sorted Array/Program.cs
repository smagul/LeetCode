// https://leetcode.com/problems/find-minimum-in-rotated-sorted-array/
// Difficulty - #Medium
// Topics - #Array, #Binary_Search

int[] nums = new int[] { 4, 5, 6, 7, 0, 1, 2 };
int min = FindMin(nums);
Console.WriteLine(min);

// Time complexity  : O(logn)
// Space complexity : O(1)
int FindMin(int[] nums)
{
    int l = 0;
    int r = nums.Length - 1;

    while (l < r)
    {
        int m = (l + r) / 2;
        if (nums[m] < nums[r])
        {
            r = m;
        }
        else
        {
            l = m + 1;
        }
    }

    return nums[l];
}
