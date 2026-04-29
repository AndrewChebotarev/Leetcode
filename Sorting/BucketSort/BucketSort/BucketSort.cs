namespace BucketSort
{
    public class BucketSort
    {
        private int[] array;
        public BucketSort(int[] array) 
        {
            this.array = array;
            Sort(this.array);

            foreach(int num in array) Console.Write(num + " ");
        }

        public void Sort(int[] array, int numberOfBuckets = 10)
        {
            if (array == null || array.Length <= 1) return;

            int min = array[0];
            int max = array[0];
            foreach (int num in array)
            {
                if (num < min) min = num;
                if (num > max) max = num;
            }

            List<int>[] buckets = new List<int>[numberOfBuckets];
            for (int i = 0; i < numberOfBuckets; i++) buckets[i] = new List<int>();

            double range = (double)(max - min) / numberOfBuckets;

            foreach (int num in array)
            {
                int bucketIndex = (int)Math.Floor((num - min) / range);
                if (bucketIndex >= numberOfBuckets) bucketIndex = numberOfBuckets - 1;

                buckets[bucketIndex].Add(num);
            }

            int currentIndex = 0;
            foreach (var bucket in buckets)
            {
                bucket.Sort();
                foreach (int num in bucket) array[currentIndex++] = num;
            }
        }
    }
}
