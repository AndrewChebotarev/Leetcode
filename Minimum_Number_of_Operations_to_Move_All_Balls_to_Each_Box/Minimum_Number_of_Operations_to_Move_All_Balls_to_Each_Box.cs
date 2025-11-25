namespace Minimum_Number_of_Operations_to_Move_All_Balls_to_Each_Box
{
    public class Minimum_Number_of_Operations_to_Move_All_Balls_to_Each_Box
    {
        private int sum = 0;
        private int[] resultArray;

        public Minimum_Number_of_Operations_to_Move_All_Balls_to_Each_Box(string boxes)
        {
            resultArray = new int[boxes.Length];

            for (int i = 0; i < boxes.Length; i++)
            {
                for (int j = 0; j < boxes.Length; j++)
                    if (boxes[j] == '1') sum += Math.Abs(i - j);

                resultArray[i] = sum;
                sum = 0;
            }

            foreach (int resultNumber in resultArray) Console.Write(resultNumber + " ");
        }
    }
}
