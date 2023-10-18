Solution solution = new();
Console.WriteLine(solution.MinimumTime(3, new int[][]
{
	new int[] { 1, 3 }, 
	new int[] { 2, 3 }
}, new int[] { 3, 2, 5 }));
Console.WriteLine(solution.MinimumTime(3, new int[][]
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

	}

	public int MinimumTime(int n, int[][] relations, int[] time)
	{
		List<int>[] graph = new List<int>[n];
		Dictionary<int, int> dp = new();
		for (int node = 0; node < n; ++node)
		{
			graph[node] = new List<int>();
		}
		return -1;
	}
}