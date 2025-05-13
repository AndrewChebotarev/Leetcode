namespace Find_The_Original_Array_of_Prefix_Xor
{
    public class Find_The_Original_Array_of_Prefix_Xor
    {
        private int[] resultArray;

        public Find_The_Original_Array_of_Prefix_Xor(int[] pref)
        {
            resultArray = new int[pref.Length];
            resultArray[0] = pref[0];

            for (int i = 1; i < pref.Length; i++)
                resultArray[i] = pref[i - 1] ^ pref[i];

            foreach (int result in resultArray)
                Console.WriteLine(result);
        }
    }
}
