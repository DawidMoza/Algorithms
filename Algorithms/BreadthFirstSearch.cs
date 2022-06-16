namespace Algorithms {
    internal static class BreadthFirstSearch {

        internal static int?[] CalculateDistances(int index, List<int[]> graph) { 
            int?[] distances = new int?[graph.Count];
            distances[index] = 0;
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(index);
            while (queue.Count > 0) {
                Dequeue(graph, queue, distances);
            }
            return distances;
        }

        private static void Dequeue(List<int[]> graph, Queue<int> queue, int?[] distances) {
            int index = queue.Dequeue();
            List<int> verticies = graph[index].Where(x => distances[x] == null).ToList();
            verticies.ForEach(x => queue.Enqueue(x));
            verticies.ForEach(x => distances[x] = distances[index] + 1);
        }
    }
}
