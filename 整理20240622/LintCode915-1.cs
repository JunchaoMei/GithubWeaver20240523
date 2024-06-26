using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    // redo
    internal class LintCode915_1
    {
        public TreeNode inorderPredecessor(TreeNode root, TreeNode p)
        {
            TreeNode pre = null;
            while (root != null)
            {
                if (root.val == p.val)
                {
                    if (root.left == null)
                    {
                        return pre;
                    }
                    root = root.left;
                    while (root.right != null)
                    {
                        root = root.right;
                    }
                    return root;
                }
                else if (root.val < p.val)
                {
                    pre = root;
                    root = root.right;
                }
                else
                {
                    root = root.left;
                }
            }
            return root;
        }
    }
}
