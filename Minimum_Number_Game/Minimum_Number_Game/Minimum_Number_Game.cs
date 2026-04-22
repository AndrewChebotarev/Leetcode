namespace Minimum_Number_Game
{
    public class Minimum_Number_Game
    {
        private List<int> startList = new();
        private List<int> resultList = new();

        private int aliceNum = 0;
        private int bobNum = 0;

        public Minimum_Number_Game(int[] nums)
        {
            ArrayToList(nums);

            while (startList.Count != 0)
            {
                AliceRemoveNum();
                BobRemoveNum();

                BobAddNum();
                AliceAddNum();
            }

            foreach (int num in resultList.ToArray()) Console.Write(num + " ");
        }

        private void AliceRemoveNum()
        {
            aliceNum = startList[0];

            for (int i = 0; i < startList.Count; i++)
                if (aliceNum > startList[i]) aliceNum = startList[i];

            startList.Remove(aliceNum);
        }

        private void BobRemoveNum()
        {
            bobNum = startList[0];

            for (int i = 0; i < startList.Count; i++)
                if (bobNum > startList[i]) bobNum = startList[i];

            startList.Remove(bobNum);
        }

        private void BobAddNum() => resultList.Add(bobNum);
        private void AliceAddNum() => resultList.Add(aliceNum);

        private void ArrayToList(int[] nums) => startList = nums.ToList();
    }
}
