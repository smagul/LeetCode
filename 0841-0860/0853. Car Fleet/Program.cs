// https://leetcode.com/problems/car-fleet/
// Difficulty - #Medium
// Topics - #Array, #Stack, #Sorting, #Monotonic_Stack

int target = 12;
int[] position = new int[] { 10, 8, 0, 5, 3 };
int[] speed = new int[] { 2, 4, 1, 1, 3 };
int numberOfFleets = CarFleet(target, position, speed);
Console.Write(numberOfFleets); // 3

// Time complexity  : O(nlogn)
// Space complexity : O(n)
int CarFleet(int target, int[] position, int[] speed)
{
    if (position.Length == 1)
    {
        return 1;
    }

    Stack<double> stack = new();
    int[][] combine = new int[position.Length][];
    for (int i = 0; i < position.Length; i++)
    {
        combine[i] = new int[2] { position[i], speed[i] };
    }

    Array.Sort(combine, (x, y) => x[0].CompareTo(y[0]));

    for (int i = combine.Length - 1; i >= 0; i--)
    {
        double currentTime = (double)(target - combine[i][0] / combine[i][1]);
        if (stack.Count > 0 && stack.Peek() >= currentTime)
        {
            continue;
        }

        stack.Push(currentTime);
    }

    return stack.Count;
}