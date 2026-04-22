namespace Timsort
{
    public class Timsort
    {
        private int[] array;
        private const int RUN = 32;
        public Timsort(int[] array) 
        {
            this.array = array;
            Sort(this.array);

            foreach (int num in array) Console.Write(num + " ");
        }

        private void Sort(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n; i += RUN)
            {
                int right = Math.Min(i + RUN - 1, n - 1);
                InsertionSort(arr, i, right);
            }

            for (int size = RUN; size < n; size = 2 * size)
            {
                for (int left = 0; left < n; left += 2 * size)
                {
                    int mid = left + size - 1;
                    int right = Math.Min(left + 2 * size - 1, n - 1);

                    if (mid < right) Merge(arr, left, mid, right);
                }
            }
        }

        private void Sort(int[] arr, int left, int right)
        {
            if (arr == null || arr.Length <= 1 || left >= right) return;

            int length = right - left + 1;
            int[] temp = new int[length];
            Array.Copy(arr, left, temp, 0, length);

            Sort(temp);

            Array.Copy(temp, 0, arr, left, length);
        }

        private void InsertionSort(int[] arr, int left, int right)
        {
            for (int i = left + 1; i <= right; i++)
            {
                int temp = arr[i];
                int j = i - 1;

                while (j >= left && arr[j] > temp)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = temp;
            }
        }

        private static void Merge(int[] arr, int left, int mid, int right)
        {
            int len1 = mid - left + 1;
            int len2 = right - mid;

            int[] leftArr = new int[len1];
            int[] rightArr = new int[len2];

            for (int i = 0; i < len1; i++) leftArr[i] = arr[left + i];
            for (int j = 0; j < len2; j++) rightArr[j] = arr[mid + 1 + j];

            int leftIndex = 0, rightIndex = 0;
            int mergeIndex = left;

            while (leftIndex < len1 && rightIndex < len2)
            {
                if (leftArr[leftIndex] <= rightArr[rightIndex])
                {
                    arr[mergeIndex] = leftArr[leftIndex];
                    leftIndex++;
                }
                else
                {
                    arr[mergeIndex] = rightArr[rightIndex];
                    rightIndex++;
                }
                mergeIndex++;
            }

            while (leftIndex < len1)
            {
                arr[mergeIndex] = leftArr[leftIndex];
                leftIndex++;
                mergeIndex++;
            }

            while (rightIndex < len2)
            {
                arr[mergeIndex] = rightArr[rightIndex];
                rightIndex++;
                mergeIndex++;
            }
        }
    }
}
