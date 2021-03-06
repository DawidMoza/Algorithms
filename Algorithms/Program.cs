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

int[] t1 = { 707, 23, 42, 7000, 1, 23, 32, 302, 9};
int[] t2 = { 27, 3, 37, 41, 3, 5552, 277, 6669};

int[] m1 = NoComparisonSorts.BucketSort(t1);
int[] m2 = NoComparisonSorts.BucketSort(t2);

m1.ToList().ForEach(x => Console.Write($"{x} "));
Console.WriteLine();
m2.ToList().ForEach(x => Console.Write($"{x} "));

Console.WriteLine();
Console.WriteLine();

//t1 = MergeSort.SortRecursive(t1);
//t2 = MergeSort.SortRecursive(t2);
//
//t1.ToList().ForEach(x => Console.Write($"{x} "));
//Console.WriteLine();
//t2.ToList().ForEach(x => Console.Write($"{x} "));

Console.WriteLine();
Console.WriteLine();

MergeSort.SortIterative(t1);
MergeSort.SortIterative(t2);

t1.ToList().ForEach(x => Console.Write($"{x} "));
Console.WriteLine();
t2.ToList().ForEach(x => Console.Write($"{x} "));