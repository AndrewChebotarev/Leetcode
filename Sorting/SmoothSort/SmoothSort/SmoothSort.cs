namespace SmoothSort
{
    public class SmoothSort
    {
        private int[] arr;

        public SmoothSort(int[] array)
        {
            this.arr = array;
            Sort();

            foreach (int num in arr) Console.Write(num + " ");
        }

        private int[] leonardo = { 1, 1, 3, 5, 9, 15, 25, 41, 67, 109, 177, 287, 465, 753, 1219, 1973, 3193, 
            5167, 8361, 13529, 21891, 35421, 57313, 92735, 150049 };

        private int GetLeonardo(int k)
        {
            if (k < 0) return 1;
            if (k >= leonardo.Length) return leonardo[leonardo.Length - 1];

            return leonardo[k];
        }

        private void SiftUp(int start, int end)
        {
            if (start >= end) return;

            int child = end;
            int parent;
            int temp;

            while (child > start)
            {
                parent = start + (child - start - 1) / 2;

                if (parent < 0 || parent >= arr.Length) break;
                if (child < 0 || child >= arr.Length) break;

                if (arr[parent] >= arr[child]) break;

                temp = arr[parent];
                arr[parent] = arr[child];
                arr[child] = temp;

                child = parent;
            }
        }

        private void SiftDown(int start, int end)
        {
            if (start >= end) return;
            if (start < 0 || end >= arr.Length) return;

            int root = start;
            int leftChild, rightChild, maxChild;
            int temp;

            while (true)
            {
                leftChild = start + (root - start) * 2 + 1;

                if (leftChild > end) break;
                if (leftChild < 0 || leftChild >= arr.Length) break;

                rightChild = leftChild + 1;
                maxChild = leftChild;

                if (rightChild <= end && rightChild >= 0 && rightChild < arr.Length)
                    if (arr[rightChild] > arr[leftChild])
                        maxChild = rightChild;

                if (root < 0 || root >= arr.Length) break;
                if (maxChild < 0 || maxChild >= arr.Length) break;

                if (arr[root] >= arr[maxChild]) break;

                temp = arr[root];
                arr[root] = arr[maxChild];
                arr[maxChild] = temp;

                root = maxChild;
            }
        }

        public void Sort()
        {
            if (arr == null || arr.Length <= 1) return;

            int n = arr.Length;

            if (n <= 32)
            {
                for (int i = 1; i < n; i++)
                {
                    int key = arr[i];
                    int j = i - 1;

                    while (j >= 0 && arr[j] > key)
                    {
                        arr[j + 1] = arr[j];
                        j--;
                    }
                    arr[j + 1] = key;
                }
                return;
            }

            int p = 1;
            int q = 1;
            int b = 1;

            for (int i = 1; i < n; i++)
            {
                if (p >= 0 && q == GetLeonardo(p + 1))
                {
                    b = GetLeonardo(p);
                    p++;
                    q = GetLeonardo(p + 1);
                }
                else
                {
                    if (q == 1) p = 0;

                    b = q;
                    q = 1;
                    p = 0;
                }

                int start = i - q + 1;

                if (start >= 0 && start <= i) SiftUp(start, i);
            }

            for (int i = n - 1; i >= 0; i--)
            {
                if (i == 0) break;

                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;

                if (q == 1)
                {
                    if (p > 0)
                    {
                        p--;
                        q = GetLeonardo(p + 1);
                        b = GetLeonardo(p);
                    }
                    else
                    {
                        q = 1;
                        b = 1;
                    }
                }
                else
                {
                    if (p - 1 >= 0)
                    {
                        q = b;
                        b = GetLeonardo(p - 1);
                        p--;
                    }
                    else
                    {
                        q = 1;
                        b = 1;
                    }
                }

                if (q > 0 && i - q + 1 >= 0) SiftDown(i - q + 1, i);
            }
        }
    }
}