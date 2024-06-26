using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    // redo
    internal class LintCode915_2
    {
        public TreeNode inorderPredecessor(TreeNode root, TreeNode p)
        {
            TreeNode pre = null;
            while (root != null)
            {
                if (root.val >= p.val)
                {
                    root = root.left;
                }
                else
                {
                    // 不是很明白这里为什么要如此判断
                    if (pre == null || pre.val < root.val)
                    {
                        pre = root;
                    }
                    root = root.right;
                }
            }
            return pre;
        }
    }
}
