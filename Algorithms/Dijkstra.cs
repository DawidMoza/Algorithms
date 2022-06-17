namespace Algorithms {
    internal static class Dijkstra {

        internal static (int?[], int?[]) FindShortest(List<(int, int, int)> graph, int graphSize, int index) { 
            bool[] visited = new bool[graphSize];
            int?[] distances = new int?[graphSize];
            int?[] prevs = new int?[graphSize];
            distances[index] = 0;
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(index);
            while (queue.Count > 0) {
                Dequeue(queue, graph, visited, distances, prevs);
            }
            return (distances, prevs);
        }

        private static void Dequeue(Queue<int> queue, List<(int, int, int)> graph, bool[] visited, int?[] distances, int?[] prevs) {
            int index = queue.Dequeue();
            visited[index] = true;
            graph.Where(x => x.Item1 == index).ToList().ForEach(x => {
                if (!visited[x.Item3]) {
                    queue.Enqueue(x.Item3);
                }
                int? newDistance = distances[x.Item1] + x.Item2;
                if (distances[x.Item3] == null || newDistance < distances[x.Item3]) {
                    distances[x.Item3] = newDistance;
                    prevs[x.Item3] = index;
                }
            });
        }
    }
}
