namespace BinarySearch
{
    public class BinarySearch
    {
        public int Searching(int[] array, int target)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (array[mid] == target) return mid;
                else if (array[mid] < target) left = mid + 1;
                else right = mid - 1;
            }

            return -1;
        }

        public int RecursiveSearching(int[] array, int target, int left, int right)
        {
            if (left > right) return -1;

            int mid = left + (right - left) / 2;

            if (array[mid] == target) return mid;
            else if (array[mid] < target) return RecursiveSearching(array, target, mid + 1, right);
            else return RecursiveSearching(array, target, left, mid - 1);
        }
    }
}
