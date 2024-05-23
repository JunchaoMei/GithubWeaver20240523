using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    // redo
    // 不会，超内存了
    internal class LintCode246_1
    {
        private List<int[]> Res;
        private int Target;
        public List<int[]> BinaryTreePathSum2(TreeNode root, int target)
        {
            this.Res = new List<int[]>();
            this.Target = target;
            this.Helper(root, new List<int>());
            return this.Res;
        }

        private void Helper(TreeNode node, List<int> path)
        {
            if (node == null)
            {
                return;
            }
            path.Add(node.val);
            if (path.Sum() == this.Target)
            {
                this.Res.Add(path.ToArray());
            }
            this.Helper(node.left, path);
            //path.RemoveAt(path.Count - 1);
            this.Helper(node.right, path);
            path.RemoveAt(path.Count - 1);
            this.Helper(node.left, new List<int>());
            this.Helper(node.right, new List<int>());
        }
    }
}
