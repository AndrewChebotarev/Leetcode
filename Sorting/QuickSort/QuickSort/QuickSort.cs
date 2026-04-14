namespace QuickSort
{
    public class QuickSort
    {
        private int[] array;

        public QuickSort(int[] array)
        {
            this.array = array;

            QuickSorting(this.array, 0, this.array.Length - 1);

            foreach (int number in this.array) Console.Write(number + " ");
        }

        private void QuickSorting(int[] array, int left, int right)
        {
            if (left < right)
            {
                int pivotIndex = Partition(array, left, right);

                QuickSorting(array, left, pivotIndex - 1);
                QuickSorting(array, pivotIndex + 1, right);
            }
            else return;
        }

        private int Partition(int[] array, int left, int right)
        {
            int pivot = array[right];
            int i = left - 1;

            for (int j = left; j < right; j++)
            {
                if (array[j] < pivot)
                {
                    i++;
                    Swap(array, i, j);
                }
            }

            Swap(array, i + 1, right);

            return i + 1;
        }

        private void Swap(int[] array, int a, int b)
        {
            int temp = array[a];
            array[a] = array[b];
            array[b] = temp;
        }
    }
}
