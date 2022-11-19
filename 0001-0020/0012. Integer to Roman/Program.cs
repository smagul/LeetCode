// https://leetcode.com/problems/integer-to-roman/
// Difficulty - #Medium
// Topics - #Hash_Table, #Math, #String

using System.Text;

string romanStr = IntToRoman(3);
Console.WriteLine(romanStr); // III

/**
 * I    1
 * V    5
 * X    10
 * L    50
 * C    100
 * D    500
 * M    1000
 **/

/**
 * Approach 1: Greedy
 **/

// Time complexity  : O(1)
// Space complexity : O(1)
string IntToRoman(int num)
{
    int[] values = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
    string[] symbols = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

    StringBuilder sb = new();
    for (int i = 0; i < values.Length; i++)
    {
        if (num == 0)
        {
            break;
        }

        while (num >= values[i])
        {
            num -= values[i];
            sb.Append(symbols[i]);
        }
    }

    return sb.ToString();
}

/**
 * Approach 2: Hash Table
 **/

// Time complexity  : O(1)
// Space complexity : O(1)
string IntToRoman2(int num)
{
    string[] M = new string[] { "", "M", "MM", "MMM" };
    string[] C = new string[] { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
    string[] X = new string[] { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
    string[] I = new string[] { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };

    return M[num / 1000] + C[num % 1000 / 100] + X[num % 100 / 10] + I[num % 10];
}