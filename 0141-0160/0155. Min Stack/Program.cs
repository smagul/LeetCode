// https://leetcode.com/problems/min-stack/
// Difficulty - #Medium
// Topics - #Stack, #Design

MinStack minStack = new();
minStack.Push(-2);
minStack.Push(0);
minStack.Push(-3);
minStack.GetMin(); // return -3
minStack.Pop();
minStack.Top();    // return 0
minStack.GetMin(); // return -2

public class MinStack
{
    private Stack<int> stack;
    private Stack<int> minStack;

    public MinStack()
    {
        stack = new();
        minStack = new();
    }

    public void Push(int val)
    {
        stack.Push(val);
        val = Math.Min(val, minStack.Count > 0 ? minStack.Peek() : val);
        minStack.Push(val);
    }

    public void Pop()
    {
        stack.Pop();
        minStack.Pop();
    }

    public int Top()
    {
        return stack.Peek();
    }

    public int GetMin() // Time complexity : O(1)
    {
        return minStack.Peek();
    }
}
