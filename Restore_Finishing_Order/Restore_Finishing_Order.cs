namespace Restore_Finishing_Order
{
    public class Restore_Finishing_Order
    {
        private int counter = 0;

        public Restore_Finishing_Order(int[] order, int[] friends)
        {
            int[] result = new int[friends.Length];

            for (int i = 0; i < order.Length; i++)
                for (int j = 0; j < friends.Length; j++)
                    if (order[i] == friends[j])
                    {
                        result[counter] = friends[j];
                        counter++;
                    }

            foreach (int value in result) Console.Write(value + " ");
        }
    }
}
