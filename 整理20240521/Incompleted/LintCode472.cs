using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    // redo
    // 不太会，超时，不知道是不是c#没人权
    internal class LintCode472
    {
        private int Target;
        private List<int[]> Res;

        public List<int[]> BinaryTreePathSum3(ParentTreeNode root, int target)
        {
            this.Target = target;
            this.Res = new List<int[]>();
            this.Dfs1(root);
            return this.Res;
        }

        public void Dfs1(ParentTreeNode node)
        {
            if (node == null)
            {
                return;
            }
            List<ParentTreeNode> path = new List<ParentTreeNode>();
            this.Dfs2(node, path, null);
            this.Dfs1(node.left);
            this.Dfs1(node.right);
        }
        public void Dfs2(ParentTreeNode node, List<ParentTreeNode> path, ParentTreeNode prev)
        {
            if (node == null)
            {
                return;
            }

            path.Add(node);

            int sum = path.Sum(n => n.val);
            if (sum == this.Target)
            {
                this.Res.Add(path.Select(n => n.val).ToArray());
            }
            if (node.left != null && node.left != prev)
            {
                this.Dfs2(node.left, path, node);
            }
            if (node.right != null && node.right != prev)
            {
                this.Dfs2(node.right, path, node);
            }
            if (node.parent != null && node.parent != prev)
            {
                this.Dfs2(node.parent, path, node);
            }
            path.RemoveAt(path.Count - 1);
        }
    }
}
