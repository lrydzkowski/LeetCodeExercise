namespace LeetCodeExercise.Core.Other;

public static class Exercise787
{
    public static int FindCheapestPrice(int n, int[][] flights, int src, int dst, int k)
    {
        Dictionary<int, List<List<int>>> graph = new();
        foreach (int[] flight in flights)
        {
            graph.TryAdd(flight[0], []);
            graph[flight[0]].Add([flight[1], flight[2]]);
        }

        List<int> prices = new();
        for (int i = 0; i < n; i++)
        {
            prices.Add(int.MaxValue);
        }

        prices[src] = 0;
        PriorityQueue<List<int>, int> heap = new();
        heap.Enqueue([src, 0, 1], 1);

        while (heap.Count > 0)
        {
            List<int> curr = heap.Dequeue();
            int node = curr[0];
            int currPrice = curr[1];
            int numberOfEdges = curr[2];

            if (numberOfEdges >= k + 2 || !graph.ContainsKey(node))
            {
                continue;
            }

            foreach (List<int> edge in graph[node])
            {
                int neighbor = edge[0];
                int price = edge[1];
                int cost = currPrice + price;
                if (cost < prices[neighbor])
                {
                    prices[neighbor] = cost;
                    heap.Enqueue([neighbor, cost, numberOfEdges + 1], numberOfEdges + 1);
                }
            }
        }

        return prices[dst] < int.MaxValue ? prices[dst] : -1;
    }
}
