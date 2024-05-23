using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    internal class LintCode519
    {
        public List<int[]> ConsistentHashing(int n)
        {
            List<int[]> res = new List<int[]>();
            int[] status = new int[3];
            status[0] = 0;
            status[1] = 359;
            status[2] = 1;
            res.Add(status);
            for (int i = 1; i < n; i++)
            {
                int max = res.OrderByDescending(s => s[1] - s[0]).First()[2];
                int[] maxArr = res.First(s => s[2] == max);
                int newStart = maxArr[0] + (maxArr[1] - maxArr[0]) / 2 + 1;
                int newEnd = maxArr[1];
                res.First(s => s[2] == maxArr[2])[1] = newStart - 1;
                res.Add(new int[3] { newStart, newEnd, i + 1 });
            }
            return res;
        }
    }
}
