namespace BFS
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("========================================");
            Console.WriteLine("   ДЕМОНСТРАЦИЯ РАБОТЫ BFS АЛГОРИТМА");
            Console.WriteLine("========================================\n");

            BFSGraph graph = new BFSGraph();

            graph.AddEdge(1, 2);
            graph.AddEdge(1, 3);
            graph.AddEdge(2, 4);
            graph.AddEdge(2, 5);
            graph.AddEdge(3, 4);
            graph.AddEdge(4, 7);
            graph.AddEdge(5, 6);
            graph.AddEdge(6, 4);
            graph.AddEdge(7, 8);

            graph.PrintGraph();

            List<int> path1 = graph.BFS(1, 8);
            if (path1 != null)
            {
                Console.WriteLine($"Кратчайший путь: {string.Join(" -> ", path1)}");
                Console.WriteLine($"Длина пути (количество ребер): {path1.Count - 1}");
            }
        }
    }
}
