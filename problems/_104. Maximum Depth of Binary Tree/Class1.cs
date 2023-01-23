﻿namespace _104._Maximum_Depth_of_Binary_Tree;

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

public class Solution
{
    public int MaxDepth(TreeNode root, int res = 0)
    {
        if (root is null)
            return res;
        res = Math.Max(MaxDepth(root.left, res + 1), MaxDepth(root.right, res + 1));
        return res;
    }
}