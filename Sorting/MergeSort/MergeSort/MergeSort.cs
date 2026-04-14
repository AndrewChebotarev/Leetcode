namespace MergeSort
{
    public class MergeSort
    {
        private int[] array;
        public MergeSort(int[] array)
        {
            this.array = array;
            int[] temp = new int[array.Length];

            MergeSorting(this.array, temp, 0, array.Length - 1);

            foreach (int number in array) Console.Write(number + " ");
        }

        private void MergeSorting(int[] array, int[] temp, int left, int right)
        {
            if (left >= right) return;

            int middle = (left + right) / 2;

            MergeSorting(array, temp, left, middle);
            MergeSorting(array, temp, middle + 1, right);

            Merge(array, temp, left, middle, right);
        }

        private void Merge(int[] array, int[] temp, int left,int middle, int right)
        {
            for (int i = left; i <= right; i++) temp[i] = array[i];

            int leftIndex = left;
            int rightIndex = middle + 1;
            int currentIndex = left;

            while (leftIndex <= middle && rightIndex <= right)
            {
                if (temp[leftIndex] <= temp[rightIndex])
                {
                    array[currentIndex] = temp[leftIndex];
                    leftIndex++;
                }
                else
                {
                    array[currentIndex] = temp[rightIndex];
                    rightIndex++;
                }
                currentIndex++;
            }

            while (leftIndex <= middle)
            {
                array[currentIndex] = temp[leftIndex];
                leftIndex++;
                currentIndex++;
            }

            while (rightIndex <= right)
            {
                array[currentIndex] = temp[rightIndex];
                rightIndex++;
                currentIndex++;
            }
        }
    }
}
