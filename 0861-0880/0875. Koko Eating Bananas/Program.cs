// https://leetcode.com/problems/koko-eating-bananas/
// Difficulty - #Medium
// Topics - #Array, #Binary_Search

int h = 8;
int[] piles = new int[] { 3, 6, 7, 11 };
int minEatingSpeed = MinEatingSpeed(piles, h);
Console.Write(minEatingSpeed); // 4

// Time complexity  : O(nlog(max(piles)))
// Space complexity : O(1)
int MinEatingSpeed(int[] piles, int h)
{
    int l = 1;
    int r = piles.Max();

    while (l < r)
    {
        int m = (l + r) / 2;

        int eatHours = 0;
        foreach (int pile in piles)
        {
            eatHours += (pile + m - 1) / m;
        }

        if (eatHours > h)
        {
            l = m + 1;
        }
        else
        {
            r = m;
        }
    }

    return l;
}