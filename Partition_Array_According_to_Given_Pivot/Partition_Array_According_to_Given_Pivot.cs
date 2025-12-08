namespace Partition_Array_According_to_Given_Pivot
{
    public class Partition_Array_According_to_Given_Pivot
    {
        private List<int> beforePivotList = new();
        private List<int> pivotList = new();
        private List<int> afterList = new();

        private List<int> resultList = new();
        public Partition_Array_According_to_Given_Pivot(int[] nums, int pivot)
        {
            foreach (int num in nums)
            {
                if (num < pivot) beforePivotList.Add(num);
                else if (num == pivot) pivotList.Add(num);
                else if (num > pivot) afterList.Add(num);
                else throw new Exception("Ошибка!");
            }

            SetResultList();
            foreach (int resultNum in ResultListToArray()) Console.Write(resultNum + " ");
        }

        private void SetResultList()
        {
            resultList.AddRange(beforePivotList);
            resultList.AddRange(pivotList);
            resultList.AddRange(afterList);
        }

        private int[] ResultListToArray() => resultList.ToArray();
    }
}
