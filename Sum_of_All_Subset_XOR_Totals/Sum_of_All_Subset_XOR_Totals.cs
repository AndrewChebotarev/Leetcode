namespace Sum_of_All_Subset_XOR_Totals
{
    public class Sum_of_All_Subset_XOR_Totals
    {
        private List<List<int>> subsets;
        private int sum = 0;

        public Sum_of_All_Subset_XOR_Totals(int[] nums)
        {
            subsets = GetAllSubsets(nums);
            XORTotal();

            Console.WriteLine(sum);
        }

        private List<List<int>> GetAllSubsets(int[] nums)
        {
            List<List<int>> subsets = new();
            subsets.Add(new List<int>());

            foreach (int num in nums)
            {
                int count = subsets.Count;

                for (int index = 0; index < count; index++)
                {
                    List<int> newSubset = new(subsets[index]);

                    newSubset.Add(num);
                    subsets.Add(newSubset);
                }
            }

            return subsets;
        }

        private void XORTotal()
        {
            foreach (List<int> subset in subsets)
            {
                int subsetResult = 0;
                for (int index = 0; index < subset.Count; index++) subsetResult ^= subset[index];

                sum += subsetResult;
            }
        }
    }
}
