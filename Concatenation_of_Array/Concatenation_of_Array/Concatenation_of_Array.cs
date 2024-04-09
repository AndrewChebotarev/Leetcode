namespace Concatenation_of_Array
{
    public class Concatenation_of_Array
    {
        public Concatenation_of_Array(int[] nums)
        {
            int[] numsX2 = new int[nums.Length * 2];

            for (int i = 0, j = 0; j < numsX2.Length; i++, j++)
            {
                if (i == nums.Length)
                    i = 0;

                numsX2[j] = nums[i];
            }

            ViewResult(numsX2);
            Console.WriteLine();
        }

        void ViewResult(int[] numsX2)
        {
            foreach (int num in numsX2)
                Console.Write(num);
        }
    }
}
