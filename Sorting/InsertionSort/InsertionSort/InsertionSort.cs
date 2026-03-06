namespace InsertionSort
{
    public class InsertionSort
    {
        public InsertionSort(int[] array) 
        {
            for (int i = 1; i < array.Length; i++)
            {
                int currentNumber = array[i];
                int j = i - 1;

                while (j >= 0 && array[j] > currentNumber)
                {
                    array[j + 1] = array[j];
                    j--;
                }

                array[j + 1] = currentNumber;
            }

            foreach (int number in array) Console.Write(number + " ");
        }
    }
}
