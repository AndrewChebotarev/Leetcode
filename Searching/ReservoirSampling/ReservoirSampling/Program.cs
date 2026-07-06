namespace ReservoirSampling
{
    public class Program
    {
        private static int[] data = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        public static void Main(string[] args)
        {
            ReservoirSampling<int> reservoirSampling = new ReservoirSampling<int>();
            foreach (int item in data) reservoirSampling.Process(item);
            int result = reservoirSampling.GetSample();
            Console.Write("Reservoir sampling k = 1: " + result);
            Console.WriteLine();

            ReservoirSamplingK<int> reservoirSamplingK = new ReservoirSamplingK<int>(3);
            foreach (int item in data) reservoirSamplingK.Process(item);
            int[] resultK = reservoirSamplingK.GetSample();
            SetResultConsole("Reservoir sampling k = 3:", resultK);
        }

        private static void SetResultConsole(string text, int[] result)
        {
            Console.Write(text);
            foreach (int num in result) Console.Write(" " + num + " ");
            Console.WriteLine();
        }
    }
}
