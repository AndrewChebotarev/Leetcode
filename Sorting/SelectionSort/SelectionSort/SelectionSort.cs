namespace SelectionSort
{
    public class SelectionSort
    {
        public SelectionSort(int[] array) 
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < array.Length; j++)
                    if (array[j] < array[minIndex])
                        minIndex = j;

                if (minIndex != i)
                {
                    int temp = array[i];
                    array[i] = array[minIndex];
                    array[minIndex] = temp;
                }
            }

            foreach (int number in array) Console.Write(number + " ");
        }
    }
}
