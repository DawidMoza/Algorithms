namespace Algorithms {
    internal static class DepthFirstSearch {

        internal static bool[] Search(int index, List<int[]> graph, bool[]? visited = null) {
            if (visited == null) {
                visited = new bool[graph.Count];
            }
            if (!visited[index]) {
                visited[index] = true;
                graph[index].Where(x => !visited[x]).ToList().ForEach(x => Search(x, graph, visited));
            }
            return visited;
        }
    }
}
