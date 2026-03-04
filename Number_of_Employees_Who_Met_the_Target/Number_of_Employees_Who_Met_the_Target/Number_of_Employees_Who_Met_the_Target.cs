namespace Number_of_Employees_Who_Met_the_Target
{
    public class Number_of_Employees_Who_Met_the_Target
    {
        public Number_of_Employees_Who_Met_the_Target(int[] hours, int target)
        {
            int result = hours.Where(employee => employee >= target).Count();
            Console.WriteLine(result);
        }
    }
}
