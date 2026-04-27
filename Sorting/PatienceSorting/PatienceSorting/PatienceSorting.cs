namespace PatienceSorting
{
    public class PatienceSorting
    {
        private int[] array;

        public PatienceSorting(int[] array)
        {
            this.array = array;
            Sort(this.array);

            foreach (int num in array) Console.Write(num + " ");
        }

        public static void Sort(int[] array)
        {
            if (array == null || array.Length <= 1) return;

            List<Stack<int>> piles = new List<Stack<int>>();

            foreach (int number in array)
            {
                int index = FindPile(piles, number);

                if (index == piles.Count)
                {
                    Stack<int> newPile = new Stack<int>();

                    newPile.Push(number);
                    piles.Add(newPile);
                }
                else piles[index].Push(number);
            }

            for (int i = 0; i < array.Length; i++)
            {
                int minIndex = 0;

                for (int j = 1; j < piles.Count; j++)
                    if (piles[j].Peek() < piles[minIndex].Peek())
                        minIndex = j;

                array[i] = piles[minIndex].Pop();

                if (piles[minIndex].Count == 0) piles.RemoveAt(minIndex);
            }
        }

        private static int FindPile(List<Stack<int>> piles, int number)
        {
            int left = 0;
            int right = piles.Count - 1;
            int result = piles.Count;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (piles[mid].Peek() >= number)
                {
                    result = mid;
                    right = mid - 1;
                }
                else left = mid + 1;
            }

            return result;
        }
    }
}
