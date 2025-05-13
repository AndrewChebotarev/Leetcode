namespace Design_Parking_System
{
    public class ParkingSystem
    {
        private int big;
        private int medium;
        private int small;

        public ParkingSystem(int big, int medium, int small)
        {
            this.big = big;
            this.medium = medium;
            this.small = small;
        }

        public bool AddCar(int carType)
        {
            if (carType == 1)
                return ChangeParkingPlaceCount(ref big);
            else if (carType == 2)
                return ChangeParkingPlaceCount(ref medium);
            else if (carType == 3)
                return ChangeParkingPlaceCount(ref small);
            else
                return false;
        }

        private bool ChangeParkingPlaceCount(ref int parkingPlaceCount)
        {
            if (parkingPlaceCount != 0)
            {
                parkingPlaceCount--;
                return true;
            }
            else
                return false;
        }
    }
}
