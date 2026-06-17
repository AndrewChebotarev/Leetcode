namespace QuickSelect
{
    public class QuickSelect
    {
        private static Random rand = new Random();

        public int FindKthSmallest(int[] array, int k)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int pivotIndex = rand.Next(left, right + 1);
                Swap(array, pivotIndex, right);

                int storeIndex = left;
                for (int i = left; i < right; i++)
                {
                    if (array[i] <= array[right])
                    {
                        Swap(array, storeIndex, i);
                        storeIndex++;
                    }
                }

                Swap(array, storeIndex, right);

                if (storeIndex == k) return array[storeIndex];
                else if (storeIndex > k) right = storeIndex - 1;
                else left = storeIndex + 1;
            }

            return -1;
        }

        public int FindKthSmallestRecursive(int[] array, int k) => RecursiveMethod(array, 0, array.Length - 1, k);

        private int RecursiveMethod(int[] array, int left, int right, int k)
        {
            if (left == right) return array[left];

            int pivotIndex = rand.Next(left, right + 1);
            Swap(array, pivotIndex, right);

            int storeIndex = left;
            for (int i = left; i < right; i++)
            {
                if (array[i] <= array[right])
                {
                    Swap(array, storeIndex, i);
                    storeIndex++;
                }
            }
            Swap(array, storeIndex, right);

            if (storeIndex == k) return array[storeIndex];
            else if (storeIndex > k) return RecursiveMethod(array, left, storeIndex - 1, k);
            else return RecursiveMethod(array, storeIndex + 1, right, k);
        }

        public int FindKthSmallestReadOnly(int[] originalArray, int k)
        {
            int[] array = (int[])originalArray.Clone();

            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int pivotIndex = rand.Next(left, right + 1);
                Swap(array, pivotIndex, right);

                int storeIndex = left;
                for (int i = left; i < right; i++)
                {
                    if (array[i] <= array[right])
                    {
                        Swap(array, storeIndex, i);
                        storeIndex++;
                    }
                }
                Swap(array, storeIndex, right);

                if (storeIndex == k) return array[storeIndex];
                else if (storeIndex > k) right = storeIndex - 1;
                else left = storeIndex + 1;
            }

            return -1;
        }

        private void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
