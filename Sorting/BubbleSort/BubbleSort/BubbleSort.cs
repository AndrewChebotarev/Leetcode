namespace BubbleSort
{
    public class BubbleSort
    {
        private bool isSorted = false;

        public BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                isSorted = false;

                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;

                        isSorted = true;
                    }
                }

                if (!isSorted) break;
            }

            foreach (int number in array) Console.Write(number + " ");
        }
    }
}
