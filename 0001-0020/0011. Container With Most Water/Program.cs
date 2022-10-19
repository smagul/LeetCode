// https://leetcode.com/problems/container-with-most-water/
// Difficulty - #Medium
// Topics - #Array, #Two_Pointers, #Greedy

int[] height = new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
int maxArea = MaxArea(height);
Console.WriteLine(maxArea); // 49

// Time complexity  : O(n)
// Space complexity : O(1)
int MaxArea(int[] height)
{
    int maxArea = 0;
    int left = 0;
    int right = height.Length - 1;
    while (left < right)
    {
        int currArea = right - left;
        if (height[left] < height[right])
        {
            currArea *= height[left++];
        }
        else
        {
            currArea *= height[right--];
        }

        maxArea = Math.Max(maxArea, currArea);
    }

    return maxArea;
}
