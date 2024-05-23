using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    internal class LintCode479
    {
        public int SecondMax(int[] nums)
        {
            // 这道题其实我理解不了第二个样例为什么会返回2...[1, 1, 2, 2]里第二大的数难道不是1么？
            int max = Math.Max(nums[0], nums[1]);
            int second = Math.Min(nums[0], nums[1]);

            for (int i = 2; i < nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    second = max;
                    max = nums[i];
                }
                else if (nums[i] > second)
                {
                    second = nums[i];
                }
            }
            return second;
        }
    }
}
