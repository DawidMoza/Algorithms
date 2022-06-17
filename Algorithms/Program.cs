using Algorithms;

List<int[]> graph1 = new List<int[]>();
graph1.Add(new int[]{ 1, 4, 2, 3 });
graph1.Add(new int[]{ 0, 2 });
graph1.Add(new int[]{ 0, 1, 3 });
graph1.Add(new int[]{ 0, 2, 4 });
graph1.Add(new int[]{ 0, 3 });

graph1.Add(new int[]{ 6 });
graph1.Add(new int[]{ 5, 7, 8 });
graph1.Add(new int[]{ 6 });
graph1.Add(new int[]{ 6 });

bool[] dfs0 = DepthFirstSearch.Search(0, graph1);
bool[] dfs5 = DepthFirstSearch.Search(5, graph1);

dfs0.ToList().ForEach(x => Console.Write($"{x} "));
Console.WriteLine();
dfs5.ToList().ForEach(x => Console.Write($"{x} "));

Console.WriteLine();
Console.WriteLine();

int?[] bfs0 = BreadthFirstSearch.CalculateDistances(0, graph1);
int?[] bfs5 = BreadthFirstSearch.CalculateDistances(5, graph1);

bfs0.ToList().ForEach(x => Console.Write($"{x} "));
Console.WriteLine();
bfs5.ToList().ForEach(x => Console.Write($"{x} "));

Console.WriteLine();
Console.WriteLine();

List<(int, int, int)> graph2 = new List<(int, int, int)>();
graph2.Add((0, 5, 1));
graph2.Add((0, 2, 2));
graph2.Add((0, 1, 3));
graph2.Add((1, 2, 3));
graph2.Add((1, 1, 4));
graph2.Add((2, 3, 3));
graph2.Add((2, 5, 4));

(int?[], int?[]) djk = Dijkstra.FindShortest(graph2, 5, 0);
djk.Item1.ToList().ForEach(x => Console.Write($"{x} "));
Console.WriteLine();
djk.Item2.ToList().ForEach(x => Console.Write($"{x} "));

Console.WriteLine();
Console.WriteLine();

int[] t1 = { 7, 3, 2, 7, 1, 3, 2, 2, 9};
int[] t2 = { 7, 3, 7, 1, 3, 2, 2, 9};

QuickSort.Sort(t1);
QuickSort.Sort(t2);

t1.ToList().ForEach(x => Console.Write($"{x} "));
Console.WriteLine();
t2.ToList().ForEach(x => Console.Write($"{x} "));