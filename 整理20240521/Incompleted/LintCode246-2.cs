using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    // redo
    // 不太会，超时了
    internal class LintCode246_2
    {
        private List<int[]> Res;
        private int Target;
        public List<int[]> BinaryTreePathSum2(TreeNode root, int target)
        {
            this.Res = new List<int[]>();
            this.Target = target;
            this.Dfs1(root);
            return this.Res;
        }

        public void Dfs1(TreeNode node)
        {
            if (node == null)
            {
                return;
            }
            List<int> path = new List<int>();
            this.Dfs2(node, path, 0);
            this.Dfs1(node.left);
            this.Dfs1(node.right);
        }
        public void Dfs2(TreeNode node, List<int> path, int sum)
        {
            if (node == null)
            {
                return;
            }

            path.Add(node.val);
            sum += node.val;
            //int sum = path.Sum(n => n.val);
            if (sum == this.Target)
            {
                this.Res.Add(path.ToArray());
            }
            if (node.left != null)
            {
                this.Dfs2(node.left, path, sum);
            }
            if (node.right != null)
            {
                this.Dfs2(node.right, path, sum);
            }
            path.RemoveAt(path.Count - 1);
        }
    }
}
