// https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
// Difficulty - #Easy
// Topics - #Array, #Dynamic_Programming

int[] prices = new int[] { 7, 1, 5, 3, 6, 4 };
int maxProfit = MaxProfit(prices);
Console.WriteLine(maxProfit); // 5

// Time complexity  : O(n)
// Space complexity : O(1)
int MaxProfit(int[] prices)
{
    int maxProfit = 0;
    int l = 0, r = 1;
    while (r < prices.Length)
    {
        if (prices[l] < prices[r])
        {
            maxProfit = Math.Max(maxProfit, prices[r] - prices[l]);
        }
        else
        {
            l = r;
        }
        r++;
    }
    return maxProfit;
}
