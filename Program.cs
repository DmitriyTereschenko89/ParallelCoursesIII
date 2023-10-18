Solution solution = new();
Console.WriteLine(solution.MinimumTime(3, new int[][]
{
	new int[] { 1, 3 }, 
	new int[] { 2, 3 }
}, new int[] { 3, 2, 5 }));
Console.WriteLine(solution.MinimumTime(5, new int[][]
{
	new int[] { 1, 5 },
	new int[] { 2, 5 },
	new int[] { 3, 5 }, 
	new int[] { 3, 4 },
	new int[] { 4, 5 }
}, new int[] { 1, 2, 3, 4, 5 }));

public class Solution
{
	private int DFS(List<int>[] graph, Dictionary<int, int> dp, int[] times, int node)
	{
		if (dp.ContainsKey(node))
		{
			return dp[node];
		}
		if (graph[node].Count == 0)
		{
			return times[node];
		}
		int maximumTime = 0;
		foreach (int child in graph[node])
		{
			maximumTime = Math.Max(maximumTime, DFS(graph, dp, times, child));
		}
		dp[node] = maximumTime + times[node];
		return dp[node];
	}

	public int MinimumTime(int n, int[][] relations, int[] time)
	{
		List<int>[] graph = new List<int>[n];
		Dictionary<int, int> dp = new();
		for (int node = 0; node < n; ++node)
		{
			graph[node] = new List<int>();
		}
		foreach (int[] relation in relations)
		{
			int prevCourse = relation[0] - 1;
			int curCourse = relation[1] - 1;
			graph[curCourse].Add(prevCourse);
		}
		int minimumTime = 0;
		for (int node = 0; node < n; ++node)
		{
			minimumTime = Math.Max(minimumTime, DFS(graph, dp, time, node));
		}
		return minimumTime;
	}
}