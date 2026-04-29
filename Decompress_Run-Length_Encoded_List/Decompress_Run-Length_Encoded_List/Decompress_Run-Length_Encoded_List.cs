namespace Decompress_Run_Length_Encoded_List
{
    public class Decompress_Run_Length_Encoded_List
    {
        private int[] result;
        private List<int> resultList;
        public Decompress_Run_Length_Encoded_List(int[] nums) 
        {
            resultList = new List<int>();

            for (int i = 0; i < nums.Length; i = i + 2)
                for (int j = 0; j < nums[i]; j++)
                    resultList.Add(nums[i + 1]);

            result = resultList.ToArray();

            foreach (int num in result) Console.Write(num + " ");
        }
    }
}
