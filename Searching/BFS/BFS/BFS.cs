namespace BFS
{
    public class BFSGraph
    {
        private Dictionary<int, List<int>> adjacencyList;
        public BFSGraph() => adjacencyList = new Dictionary<int, List<int>>();

        public void AddVertex(int vertex)
        {
            if (!adjacencyList.ContainsKey(vertex)) adjacencyList[vertex] = new List<int>();
        }

        public void AddEdge(int from, int to)
        {
            AddVertex(from);
            AddVertex(to);

            adjacencyList[from].Add(to);
            adjacencyList[to].Add(from);
        }

        public List<int> BFS(int start, int target)
        {
            if (!adjacencyList.ContainsKey(start) || !adjacencyList.ContainsKey(target))
            {
                Console.WriteLine($"Вершина {start} или {target} не найдена в графе");
                return null;
            }

            Queue<int> queue = new Queue<int>();
            HashSet<int> visited = new HashSet<int>();
            Dictionary<int, int> parent = new Dictionary<int, int>();

            queue.Enqueue(start);
            visited.Add(start);
            parent[start] = -1;

            Console.WriteLine($"\nНачинаем BFS поиск от {start} до {target}");
            Console.WriteLine("----------------------------------------");

            int step = 0;
            while (queue.Count > 0)
            {
                int current = queue.Dequeue();
                step++;

                Console.WriteLine($"Шаг {step}: Обрабатываем вершину {current}");

                if (current == target)
                {
                    Console.WriteLine($"Цель {target} найдена!");
                    return BuildPath(parent, start, target);
                }

                foreach (int neighbor in adjacencyList[current])
                {
                    if (!visited.Contains(neighbor))
                    {
                        visited.Add(neighbor);
                        parent[neighbor] = current;
                        queue.Enqueue(neighbor);

                        Console.WriteLine($"   Добавляем в очередь: {neighbor} (пришли из {current})");
                    }
                }
            }

            Console.WriteLine($"Путь от {start} до {target} не найден");
            return null;
        }

        private List<int> BuildPath(Dictionary<int, int> parent, int start, int target)
        {
            List<int> path = new List<int>();
            int current = target;

            while (current != -1)
            {
                path.Add(current);
                if (current == start) break;

                current = parent[current];
            }

            path.Reverse();
            return path;
        }

        public void PrintGraph()
        {
            Console.WriteLine("\nТекущий граф:");
            Console.WriteLine("----------------------------------------");

            foreach (var vertex in adjacencyList.OrderBy(v => v.Key))
                Console.WriteLine($"Вершина {vertex.Key} -> [{string.Join(", ", vertex.Value)}]");

            Console.WriteLine("----------------------------------------");
        }
    }
}
