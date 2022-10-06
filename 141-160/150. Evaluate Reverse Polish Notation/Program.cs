// https://leetcode.com/problems/evaluate-reverse-polish-notation/
// Difficulty - #Medium
// Topics - #Array, #Math, #Stack

string[] tokens = new string[] { "2", "1", "+", "3", "*" };
int result = EvalRPN(tokens);
Console.WriteLine(result); // 9

int EvalRPN(string[] tokens)
{
    Stack<int> stack = new();

    foreach (string token in tokens)
    {
        switch (token)
        {
            case "+":
                stack.Push(stack.Pop() + stack.Pop());
                break;
            case "-":
                int sub = stack.Pop();
                stack.Push(stack.Pop() - sub);
                break;
            case "*":
                stack.Push(stack.Pop() * stack.Pop());
                break;
            case "/":
                int div = stack.Pop();
                stack.Push(stack.Pop() / div);
                break;
            default:
                stack.Push(Convert.ToInt32(token));
                break;
        }
    }

    return stack.ElementAt(0);
}
