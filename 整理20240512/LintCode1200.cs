using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    internal class LintCode1200
    {
        public string[] FindRelativeRanks(int[] nums)
        {
            IDictionary<int, int> dict = new Dictionary<int, int>();
            string[] res = new string[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                dict[nums[i]] = i;
            }
            // [3, 1, 2, 5, 4]
            Array.Sort(nums);
            // [1, 2, 3, 4, 5]
            for (int i = 0; i < nums.Length; i++)
            {
                int pos = dict[nums[i]];
                string rank = "";
                if (i == nums.Length - 1)
                {
                    rank = "Gold Medal";
                }
                else if (i == nums.Length - 2)
                {
                    rank = "Silver Medal";
                }
                else if (i == nums.Length - 3)
                {
                    rank = "Bronze Medal";
                }
                else
                {
                    rank = $"{nums.Length - i}";
                }
                res[pos] = rank;
            }
            return res;
        }
    }
}
