namespace Kids_With_the_Greatest_Number_of_Candies
{
    public class Kids_With_the_Greatest_Number_of_Candies
    {
        private IList<bool> resultList = new List<bool>();

        public Kids_With_the_Greatest_Number_of_Candies(int[] candies, int extraCandies)
        {
            for (int index = 0; index < candies.Length; index++)
            {
                int temp = candies[index] + extraCandies;

                if (CompareNumbers(candies, temp)) resultList.Add(true);
                else resultList.Add(false);
            }
            
            foreach (bool result in resultList) Console.Write(result.ToString() + " ");

            Console.WriteLine();
        }

        private bool CompareNumbers(int[] candies, int number)
        {
            for (int index = 0; index < candies.Length; index++)
                if (number < candies[index]) return false;

            return true;
        }
    }
}
