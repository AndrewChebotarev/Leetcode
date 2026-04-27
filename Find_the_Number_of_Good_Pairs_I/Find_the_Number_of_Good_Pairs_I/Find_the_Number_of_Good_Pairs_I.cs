namespace Find_the_Number_of_Good_Pairs_I
{
    public class Find_the_Number_of_Good_Pairs_I
    {
        private int result = 0;
        public Find_the_Number_of_Good_Pairs_I(int[] nums1, int[] nums2, int k)
        {
            for (int i = 0; i < nums1.Length; i++)
                for (int j = 0; j < nums2.Length; j++)
                    if (nums1[i] % (nums2[j] * k) == 0) result++;

            Console.WriteLine(result);
        }
    }
}
