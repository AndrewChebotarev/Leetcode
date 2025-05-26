namespace Richest_Customer_Wealth
{
    public class Richest_Customer_Wealth
    {
        private int sumRichestClient = 0;
        private int sumClient = 0;

        public Richest_Customer_Wealth(int[][] accounts)
        {
            for (int i = 0; i < accounts.Length; i++)
            {
                for (int j = 0; j < accounts[i].Length; j++)
                    sumClient += accounts[i][j];

                CheckSumRichestClient();
                ClearSumClient();
            }

            Console.WriteLine(sumRichestClient.ToString());
        }

        private void CheckSumRichestClient()
        {
            if (sumRichestClient < sumClient)
                sumRichestClient = sumClient;
        }

        private void ClearSumClient() => sumClient = 0;
    }
}
