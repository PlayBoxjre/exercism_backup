using System;
using System.Collections.Generic;
using System.Linq;

// AI generate code 
// don't understand this question 
public static class Dominoes
{
    public static bool CanChain(IEnumerable<(int, int)> dominoes)
    {
        var list = dominoes.ToList();
        if (list.Count == 0)
            return true; // 空序列视为合法（exercism 标准）

        var degree = new Dictionary<int, int>();
        var graph = new Dictionary<int, List<int>>();

        foreach (var (a, b) in list)
        {
            if (!degree.ContainsKey(a)) degree[a] = 0;
            if (!degree.ContainsKey(b)) degree[b] = 0;
            degree[a]++;
            degree[b]++;

            if (!graph.ContainsKey(a)) graph[a] = new List<int>();
            if (!graph.ContainsKey(b)) graph[b] = new List<int>();
            graph[a].Add(b);
            graph[b].Add(a);
        }

        // 欧拉回路条件1：所有顶点度数都是偶数
        if (degree.Any(kv => kv.Value % 2 != 0))
            return false;

        // 条件2：所有有度数的点连通（BFS）
        var start = degree.Keys.First();
        var visited = new HashSet<int>();
        var queue = new Queue<int>();
        queue.Enqueue(start);
        visited.Add(start);

        while (queue.Count > 0)
        {
            var u = queue.Dequeue();
            foreach (var v in graph[u])
            {
                if (!visited.Contains(v))
                {
                    visited.Add(v);
                    queue.Enqueue(v);
                }
            }
        }

        // 只要存在一个有度数但是没访问到的点 → 不连通
        if (degree.Keys.Any(node => !visited.Contains(node)))
            return false;

        return true;
    }
}
