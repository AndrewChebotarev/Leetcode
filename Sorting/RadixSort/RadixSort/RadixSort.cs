namespace RadixSort
{
    public class RadixSort
    {
        private int[] array;

        public RadixSort(int[] array)
        {
            this.array = array;
            Sort(this.array);
            foreach (int num in this.array) Console.Write(num + " ");
        }

        private void Sort(int[] array)
        {
            if (array == null || array.Length <= 1) return;

            int max = array.Max(x => Math.Abs(x));

            for (int exp = 1; max / exp > 0; exp *= 10) CountingSortByDigit(array, exp);
        }

        private void CountingSortByDigit(int[] array, int exp)
        {
            int n = array.Length;
            int[] output = new int[n];
            int[] count = new int[10];

            for (int i = 0; i < n; i++)
            {
                int digit = (array[i] / exp) % 10;
                count[digit]++;
            }

            for (int i = 1; i < 10; i++) count[i] += count[i - 1];

            for (int i = n - 1; i >= 0; i--)
            {
                int digit = (array[i] / exp) % 10;
                output[count[digit] - 1] = array[i];

                count[digit]--;
            }

            for (int i = 0; i < n; i++) array[i] = output[i];
        }
    }
}

