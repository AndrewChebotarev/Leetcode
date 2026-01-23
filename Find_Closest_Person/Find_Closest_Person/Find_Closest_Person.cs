namespace Find_Closest_Person
{
    public class Find_Closest_Person
    {
        public Find_Closest_Person(int x, int y, int z) 
        {
            int xSteps = Math.Abs(z - x);
            int ySteps = Math.Abs(z - y);

            if (xSteps < ySteps) Console.WriteLine("1");
            else if (xSteps > ySteps) Console.WriteLine("2");
            else Console.WriteLine("0");
        }
    }
}
