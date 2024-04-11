namespace Find_the_Maximum_Achievable_Number
{
    public class Find_the_Maximum_Achievable_Number
    {
        public Find_the_Maximum_Achievable_Number(int num, int t)
        {
            int x = 0;
            for (; t > 0; x++, num++, t--){}
            Console.WriteLine(num + x);
        }
    }
}
