namespace Jewels_and_Stones
{
    public class Jewels_and_Stones
    {
        private int jewelsInStonesCount = 0;

        public Jewels_and_Stones(string jewels, string stones) 
        {
            foreach (char jewel in jewels)
                foreach (char stone in stones)
                    if (jewel == stone)
                        jewelsInStonesCount++;

            Console.WriteLine(jewelsInStonesCount);
        }
    }
}
