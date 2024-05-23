using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    // redo
    internal class LintCode475
    {
        private int Max;
        public int MaxPathSum2(TreeNode root)
        {
            this.Max = int.MinValue;
            this.Helper(root, root.val);
            return this.Max;
        }

        private void Helper(TreeNode node, int sum)
        {
            if (node == null)
            {
                return;
            }
            this.Max = Math.Max(this.Max, sum);
            if (node.left != null)
            {
                this.Helper(node.left, sum + node.left.val);
            }
            if (node.right != null)
            {
                this.Helper(node.right, sum + node.right.val);
            }
        }
    }
}
