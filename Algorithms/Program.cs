using Algorithms;

List<int[]> graph = new List<int[]>();
graph.Add(new int[]{ 1, 4, 2, 3 });
graph.Add(new int[]{ 0, 2 });
graph.Add(new int[]{ 0, 1, 3 });
graph.Add(new int[]{ 0, 2, 4 });
graph.Add(new int[]{ 0, 3 });

graph.Add(new int[]{ 6 });
graph.Add(new int[]{ 5, 7, 8 });
graph.Add(new int[]{ 6 });
graph.Add(new int[]{ 6 });

bool[] dfs0 = DepthFirstSearch.Search(0, graph);
bool[] dfs5 = DepthFirstSearch.Search(5, graph);

dfs0.ToList().ForEach(x => Console.Write($"{x} "));
Console.WriteLine();
dfs5.ToList().ForEach(x => Console.Write($"{x} "));

Console.WriteLine();
Console.WriteLine();

int?[] bfs0 = BreadthFirstSearch.CalculateDistances(0, graph);
int?[] bfs5 = BreadthFirstSearch.CalculateDistances(5, graph);

bfs0.ToList().ForEach(x => Console.Write($"{x} "));
Console.WriteLine();
bfs5.ToList().ForEach(x => Console.Write($"{x} "));

Console.WriteLine();
Console.WriteLine();