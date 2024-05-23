using System.Linq;

namespace LeetCode
{
    internal class LintCode87
    {
        // 按照题解写的，但是不过，不知道问题在哪
        private TreeNode predecessor(TreeNode node)
        {
            TreeNode cur = node.left;
            while (cur.right != null)
            {
                cur = cur.right;
            }
            return cur;
        }

        private TreeNode successor(TreeNode node)
        {
            TreeNode cur = node.right;
            while (cur.left != null)
            {
                cur = cur.left;
            }
            return cur;
        }

        public TreeNode removeNode(TreeNode root, int value)
        {
            if (root == null)
            {
                return null;
            }
            if (root.val > value)
            {
                root.left = this.removeNode(root.left, value);
            }
            else if (root.val < value)
            {
                root.right = this.removeNode(root.right, value);
            }
            else
            {
                // 如果是叶节点，则返回null
                if (root.left == null && root.right == null)
                {
                    root = null;
                }
                // 如果左节点为空，则用successor替换当前节点，然后递归下行删除与当前节点新值相同的原节点
                else if (root.left == null)
                {
                    root.val = this.successor(root).val;
                    root.right = this.removeNode(root.right, root.val);
                }
                // 如果右节点为空，则用predecessor替换当前节点，然后递归下行删除与当前节点新值相同的原节点
                else if (root.right == null)
                {
                    root.val = this.predecessor(root).val;
                    root.left = this.removeNode(root.left, root.val);
                }
            }
            return root;
        }
    }
}
