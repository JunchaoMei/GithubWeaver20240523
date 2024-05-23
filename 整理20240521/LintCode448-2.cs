using System.Collections.Generic;

namespace LeetCode
{
    // converted from java
    // redo
    internal class LintCode448_2
    {
        public TreeNode inorderSuccessor(TreeNode root, TreeNode p)
        {
            if (root == null)
            {
                return null;
            }
            // 如果有右子树，则后继点一定在右子树的最左侧
            if (p.right != null)
            {
                TreeNode curr = p.right;
                while (curr.left != null)
                {
                    curr = curr.left;
                }
                return curr;
            }
            // 如果不存在右子树，则目标点父节点即为后继点
            TreeNode cur = root;
            TreeNode pre = null;// 记录pre，找到目标点后返回pre即为后继点
            while (cur != p)
            {
                if (cur.val > p.val)
                {
                    pre = cur;
                    cur = cur.left;
                }
                else if (cur.val < p.val)
                {
                    cur = cur.right;
                }
            }
            return pre;
        }
    }
}
