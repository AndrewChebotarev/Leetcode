namespace Minimum_Number_of_Moves_to_Seat_Everyone
{
    public class Minimum_Number_of_Moves_to_Seat_Everyone
    {
        private int resultSteps = 0;

        public Minimum_Number_of_Moves_to_Seat_Everyone(int[] seats, int[] students)
        {
            Array.Sort(seats);
            Array.Sort(students);

            for (int i = 0; i < seats.Length; i++) resultSteps += Math.Abs(seats[i] - students[i]);

            Console.WriteLine(resultSteps);
        }
    }
}
