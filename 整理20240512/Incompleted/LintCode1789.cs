using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    internal class LintCode1789
    {
        // 超时了
        public string[] DistinguishUsername(string[] names)
        {
            if (names.Length == 0)
            {
                return new string[0];
            }
            IDictionary<string, int> dict = new Dictionary<string, int>();
            for (int i = 0; i < names.Length; i++)
            {
                if (!dict.ContainsKey(names[i]))
                {
                    dict[names[i]] = -1;
                }
                dict[names[i]]++;
                if (dict[names[i]] > 0)
                {
                    names[i] += (char)('0' + dict[names[i]]);
                }
            }
            return names;
        }
    }
}
