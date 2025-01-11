namespace Final_Value_of_Variable_After_Performing_Operations
{
    public class Final_Value_of_Variable_After_Performing_Operations
    {
        private int result = 0;

        public Final_Value_of_Variable_After_Performing_Operations(string[] operations) 
        {
            foreach (string operation in operations)
            {
                if (operation.Contains("-"))
                    result--;
                else if (operation.Contains("+"))
                    result++;
            }

            Console.WriteLine(result.ToString());
        }
    }
}
