using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    // redo
    // 3
    // [[1,0]] 不过，不知道问题在哪
    internal class LintCode615
    {
        public bool CanFinish(int numCourses, int[][] prerequisites)
        {
            if (prerequisites.Length == 0 || prerequisites[0].Length == 0)
            {
                return true;
            }
            IList<List<int>> edges = new List<List<int>>();
            for (int i = 0; i < numCourses; i++)
            {
                edges.Add(new List<int>());
            }
            int[] indegree = new int[numCourses];
            foreach (int[] req in prerequisites)
            {
                edges[req[1]].Add(req[0]);
                indegree[req[0]]++;
            }

            Queue<int> queue = new Queue<int>();
            for (int i = 0; i < numCourses; i++)
            {
                if (indegree[i] == 0)
                {
                    queue.Enqueue(i);
                }

            }

            int taken = 0;
            while (queue.Count > 0)
            {
                int count = queue.Count;
                for (int i = 0; i < count; i++)
                {
                    int cur = queue.Dequeue();
                    foreach (int target in edges[cur])
                    {
                        indegree[target]--;
                        if (indegree[target] == 0)
                        {
                            queue.Enqueue(target);
                        }
                    }
                }
                taken++;
            }
            return taken == numCourses;
        }
    }
}
