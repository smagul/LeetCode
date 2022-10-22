// https://leetcode.com/problems/excel-sheet-column-title/
// Difficulty - #Easy
// Topics - #Math, #String

int columnNumber = 701;
string result = ConvertToTitle(columnNumber);
Console.WriteLine(result); // ZY

// Time complexity  : O(n)
// Space complexity : O(1)
string ConvertToTitle(int columnNumber)
{
    return columnNumber == 0
        ? string.Empty
        : ConvertToTitle((columnNumber - 1) / 26) + (char)('A' + (columnNumber - 1) % 26);
}
