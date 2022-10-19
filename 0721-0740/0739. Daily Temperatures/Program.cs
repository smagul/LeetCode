// https://leetcode.com/problems/daily-temperatures/
// Difficulty - #Medium
// Topics - #Array, #Stack, #Monotonic_Stack

int[] temperatures = new int[] { 73, 74, 75, 71, 69, 72, 76, 73 };
int[] days = DailyTemperatures(temperatures);
foreach (int day in days)
{
    Console.Write(day + " "); // 1,1,4,2,1,1,0,0
}

// Time complexity  : O(n)
// Space complexity : O(n)
int[] DailyTemperatures(int[] temperatures)
{
    int[] ans = new int[temperatures.Length];
    Stack<int> stack = new();
    for (int currDay = 0; currDay < temperatures.Length; currDay++)
    {
        while (stack.Count > 0 && temperatures[currDay] > temperatures[stack.Peek()])
        {
            int prevDay = stack.Pop();
            ans[prevDay] = currDay - prevDay;
        }
        stack.Push(currDay);
    }

    return ans;
}