namespace ReservoirSampling
{
    public class ReservoirSamplingK<T>
    {
        private readonly Random random = new Random();
        private readonly T[] reservoir;
        private int count = 0;

        public ReservoirSamplingK(int k) => reservoir = new T[k];

        public void Process(T item)
        {
            count++;
            if (count <= reservoir.Length) reservoir[count - 1] = item;
            else
            {
                int r = random.Next(count);
                if (r < reservoir.Length) reservoir[r] = item;
            }
        }

        public T[] GetSample() => reservoir;
    }
}
