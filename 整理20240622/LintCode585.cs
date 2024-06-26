using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    internal class LintCode585
    {
        public int MountainSequence(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }
            int left = 0;
            int right = nums.Length - 1;
            while (left + 1 < right)
            {
                int mid = left + (right - left) / 2;
                //查看mid与mid+1判断递增还是递减，这是因为题目提到峰值两端为严格单调递增或者递减
                if (nums[mid] > nums[mid + 1])
                {
                    right = mid;
                }
                else
                {
                    left = mid;
                }
            }
            return Math.Max(nums[left], nums[right]);
        }
    }
}
