using System;
using System.Collections.Generic;

namespace LeetCode
{
    internal class LintCode864_1
    {
        // 一开始想写无返回类型，但是没写出来
        private int SumTotal;
        private ISet<int> HashSet;
        public bool CheckEqualTree(TreeNode root)
        {
            if (root == null)
            {
                return false;
            }
            this.SumTotal = 0;
            this.HashSet = new HashSet<int>();
            this.Helper(root, 0);
            return (this.SumTotal % 2 == 0) && this.HashSet.Contains(this.SumTotal / 2);
        }

        public void Helper(TreeNode node, int sumCur)
        {
            if (node == null)
            {
                return;
            }
            sumCur += node.val;
            this.SumTotal += node.val;
            this.HashSet.Add(sumCur);
            this.Helper(node.left, sumCur);
            this.Helper(node.right, sumCur);
        }
    }
}
