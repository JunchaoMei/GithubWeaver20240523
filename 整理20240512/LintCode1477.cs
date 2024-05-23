using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    internal class LintCode1477
    {
        public int CarFleet(int target, int[] position, int[] speed)
        {
            IDictionary<int, double> dict = new Dictionary<int, double>();
            int n = position.Length;
            for (int i = 0; i < n; i++)
            {
                dict[position[i]] = (double)(target - position[i]) / speed[i];
            }
            int res = 0;
            double curTime = 0;
            var ordered = dict.OrderByDescending(p => p.Key).Select(p => p.Value);

            foreach (double time in ordered)
            {
                if (time > curTime)
                {
                    res++;
                    curTime = time;
                }
            }
            return res;
        }
    }
}
