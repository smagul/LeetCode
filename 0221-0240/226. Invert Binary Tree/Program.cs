// https://leetcode.com/problems/invert-binary-tree/
// Difficulty - #Easy
// Topics - #Tree, #Depth-First_Search, #Breadth-First_Search, #Binary_Tree

var root = InvertTree(new(4, new(2, new(7, new(1, new(3, new(6, new(9, null))))))));
while (root != null)
{
    Console.WriteLine(root.val); // 4,7,2,9,6,3,1
    while (root.left != null)
    {
        Console.WriteLine(root.left.val);
        root.left = root.left.left;
        root.right = root.left.right;
    }

    if (root.right != null)
    {
        Console.WriteLine(root.right.val);
        root.right = root.right.right;
    }
}

// Time complexity  : O(n)
// Space complexity : O(n)
TreeNode InvertTree(TreeNode root)
{
    if (root == null)
    {
        return null;
    }

    TreeNode left = root.left;
    TreeNode right = root.right;
    root.left = InvertTree(right);
    root.right = InvertTree(left);

    return root;
}

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}