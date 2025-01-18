namespace Defanging_an_IP_Address
{
    public class Defanging_an_IP_Address
    {
        private string? newAddress;
        public Defanging_an_IP_Address(string address) 
        {
            foreach (char symbol in address)
            {
                if (symbol == '.')
                    newAddress += "[" + symbol + "]";
                else
                    newAddress += symbol;
            }

            Console.WriteLine(newAddress);
        }
    }
}
