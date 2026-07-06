namespace ReservoirSampling
{
    public class ReservoirSampling<T>
    {
        private readonly Random random = new Random();
        private T reservoir;
        private int count = 0;

        public void Process(T item)
        {
            count++;
            if (count == 1) reservoir = item;
            else if (random.Next(count) == 0) reservoir = item;
        }

        public T GetSample() => reservoir;
    }
}
