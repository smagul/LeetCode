// https://leetcode.com/problems/search-a-2d-matrix/
// Difficulty - #Medium
// Topics - #Array, #Binary_Search, #Matrix

int[][] matrix = new int[][]
{
    new int[] { 1, 3, 5, 7 },
    new int[] { 10, 11, 16, 20 },
    new int[] { 23, 30, 34, 60 }
};
int target = 3;
bool isExist = SearchMatrix(matrix, target);
Console.WriteLine(isExist); // true

// Time complexity  : O(mnlogmn)
// Space complexity : O(1)
bool SearchMatrix(int[][] matrix, int target)
{
    int n = matrix.Length;
    int m = matrix[0].Length;
    int left = 0;
    int right = n * m;

    while (left < right)
    {
        int mid = (left + right) / 2;
        int i = mid / n;
        int j = mid % n;
        if (matrix[i][j] > target)
        {
            right = mid;
        }
        else if (matrix[i][j] < target)
        {
            left = mid + 1;
        }
        else
        {
            return true;
        }
    }

    return false;
}
