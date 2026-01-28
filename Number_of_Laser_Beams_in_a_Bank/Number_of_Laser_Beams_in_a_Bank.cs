namespace Number_of_Laser_Beams_in_a_Bank
{
    public class Number_of_Laser_Beams_in_a_Bank
    {
        private int result = 0;
        private List<string> bankList;

        public Number_of_Laser_Beams_in_a_Bank(string[] bank)
        {
            CreateNewBankList(bank);

            if (CheckNullResult()) Console.WriteLine(result);
            else GetResult();

            Console.WriteLine(result);
        }

        private void CreateNewBankList(string[] bank)
        {
            bankList = new List<string>();

            for (int index = 0; index < bank.Length; index++)
                if (bank[index].Contains('1')) bankList.Add(bank[index]);
        }

        private bool CheckNullResult() => bankList.Count == 0;

        private void GetResult()
        {
            for (int index = 0; index < bankList.Count - 1; index++)
            {
                int countCharFirst = bankList[index].Count(c => c == '1');
                int countCharSecond = bankList[index + 1].Count(c => c == '1');

                result += countCharFirst * countCharSecond;
            }
        }
    }
}
