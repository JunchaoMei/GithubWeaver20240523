using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    // redo
    internal class LintCode18_1
    {
        private List<int[]> Res;
        private List<int> Sub;
        private int[] Nums;
        public List<int[]> SubsetsWithDup(int[] nums)
        {
            this.Res = new List<int[]>();
            this.Sub = new List<int>();
            Array.Sort(nums);
            this.Nums = nums;
            this.Helper(0);
            return this.Res;
        }

        private void Helper(int idx)
        {
            if (idx == this.Nums.Length)
            {
                int[] arr = this.Sub.ToArray();
                if (!this.Res.Any(a => a.SequenceEqual(arr)))
                {
                    this.Res.Add(arr);
                }
                return;
            }
            this.Sub.Add(this.Nums[idx]);
            this.Helper(idx + 1);
            this.Sub.RemoveAt(this.Sub.Count - 1);
            this.Helper(idx + 1);
        }
    }
}
