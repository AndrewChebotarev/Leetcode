namespace Convert_the_Temperature
{
    public class Convert_the_Temperature
    {
        private double kelvin;
        private double fahrenheit;

        public Convert_the_Temperature(double celsius)
        {
            kelvin = celsius + 273.15;
            fahrenheit = celsius * 1.80 + 32.00;

            double[] result =  new double[] { kelvin, fahrenheit };

            Console.WriteLine("Кельвин: {0:F5}, Фаренгейт: {1:F5}", kelvin, fahrenheit);
        }
    }
}
